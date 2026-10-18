using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BookManagement
{
    public partial class formBookManager : Form
    {
        private BindingList<BookModel> bookList;
        private BindingSource bindingSource;
        private int bookCounter = 1;

        public formBookManager()
        {
            InitializeComponent();
            RegisterEvents();
            SetupDataGridView();
            SetupDataBinding();
            LoadSampleData();
            PrepareForNewBook();

            // Khởi chạy đồng hồ thời gian thực
            timerClock.Start();
            UpdateStatusStrip();
        }

        private void RegisterEvents()
        {
            // Event đếm thời gian thực
            timerClock.Tick += (s, e) => lblStatusTime.Text = $"Thời gian: {DateTime.Now:dd/MM/yyyy HH:mm:ss}";

            // MenuStrip Events
            menuOpenCsv.Click += (s, e) => ImportFromCsv();
            menuSaveCsv.Click += (s, e) => ExportToCsv();
            menuExit.Click += (s, e) => Application.Exit();
            menuAdd.Click += (s, e) => BtnAdd_Click(s, e);
            menuDelete.Click += (s, e) => BtnDelete_Click(s, e);
            menuSearch.Click += (s, e) => txtSearch.Focus();

            // ToolStrip Events
            btnToolOpen.Click += (s, e) => ImportFromCsv();
            btnToolSave.Click += (s, e) => ExportToCsv();
            btnToolAdd.Click += (s, e) => BtnAdd_Click(s, e);

            // Button Events
            btnBrowseCover.Click += BtnBrowseCover_Click;
            btnAdd.Click += BtnAdd_Click;
            btnEdit.Click += BtnEdit_Click;
            btnDelete.Click += BtnDelete_Click;
            btnReset.Click += BtnReset_Click;
            btnSearch.Click += BtnSearch_Click;
            txtSearch.TextChanged += (s, e) => BtnSearch_Click(s, e);

            // Cập nhật đường dẫn ảnh khi chọn dòng trên DGV
            bindingSourcePositionChangedHandler = (s, e) => LoadSelectedCoverImage();
        }

        private EventHandler bindingSourcePositionChangedHandler;

        private void SetupDataGridView()
        {
            // Khai báo DataGridView hoàn toàn bằng code (AutoGenerateColumns = false)
            dgvMembersSetup(dgvBooks);
        }

        private void dgvMembersSetup(DataGridView dgv)
        {
            dgv.AutoGenerateColumns = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.ReadOnly = true;
            dgv.MultiSelect = false;
            dgv.AllowUserToAddRows = false;

            dgv.Columns.Clear();
            dgv.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "BookId",
                HeaderText = "Mã Sách",
                Width = 80
            });
            dgv.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Title",
                HeaderText = "Tên Sách",
                Width = 200
            });
            dgv.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Author",
                HeaderText = "Tác Giả",
                Width = 140
            });
            dgv.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Category",
                HeaderText = "Thể Loại",
                Width = 120
            });
            dgv.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Price",
                HeaderText = "Đơn Giá",
                Width = 100,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "N0", Alignment = DataGridViewContentAlignment.MiddleRight }
            });
            dgv.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Quantity",
                HeaderText = "Số Lượng",
                Width = 80,
                DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter }
            });
            dgv.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "TotalValue",
                HeaderText = "Thành Tiền",
                Width = 110,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "N0", Alignment = DataGridViewContentAlignment.MiddleRight }
            });
            dgv.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "CoverPath",
                HeaderText = "Ảnh Bìa",
                Width = 130
            });
        }

        private void SetupDataBinding()
        {
            bookList = new BindingList<BookModel>();

            // Tự động lắng nghe thay đổi danh sách để tính lại StatusStrip
            bookList.ListChanged += (s, e) => UpdateStatusStrip();

            bindingSource = new BindingSource { DataSource = bookList };
            dgvBooks.DataSource = bindingSource;

            bindingSource.PositionChanged += (s, e) => bindingSourcePositionChangedHandler?.Invoke(s, e);

            // Ràng buộc 2 chiều dữ liệu giữa Model và Control
            txtBookId.DataBindings.Add("Text", bindingSource, "BookId", true, DataSourceUpdateMode.OnPropertyChanged);
            txtTitle.DataBindings.Add("Text", bindingSource, "Title", true, DataSourceUpdateMode.OnPropertyChanged);
            txtAuthor.DataBindings.Add("Text", bindingSource, "Author", true, DataSourceUpdateMode.OnPropertyChanged);
            cboCategory.DataBindings.Add("Text", bindingSource, "Category", true, DataSourceUpdateMode.OnPropertyChanged);
            txtCoverPath.DataBindings.Add("Text", bindingSource, "CoverPath", true, DataSourceUpdateMode.OnPropertyChanged);

            Binding priceBinding = new Binding("Text", bindingSource, "Price", true, DataSourceUpdateMode.OnPropertyChanged, 0, "N0");
            txtPrice.DataBindings.Add(priceBinding);

            Binding qtyBinding = new Binding("Text", bindingSource, "Quantity", true, DataSourceUpdateMode.OnPropertyChanged, 0);
            txtQuantity.DataBindings.Add(qtyBinding);
        }

        private void LoadSampleData()
        {
            bookList.Add(new BookModel
            {
                BookId = GenerateBookId(),
                Title = "Lập Trình C# WinForms",
                Author = "Nguyễn Văn A",
                Category = "Công nghệ thông tin",
                Price = 120000,
                Quantity = 50,
                CoverPath = "sample_csharp.jpg"
            });

            bookList.Add(new BookModel
            {
                BookId = GenerateBookId(),
                Title = "Đắc Nhân Tâm",
                Author = "Dale Carnegie",
                Category = "Kỹ năng sống",
                Price = 85000,
                Quantity = 100,
                CoverPath = "sample_dacnhantam.jpg"
            });
        }

        private string GenerateBookId()
        {
            return $"MS{bookCounter++:D3}";
        }

        // ================= 1. NẠP VÀ HIỂN THỊ ẢNH BÌA (OpenFileDialog) =================
        private void BtnBrowseCover_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Chọn ảnh bìa sách";
                ofd.Filter = "Tập tin hình ảnh (*.jpg; *.jpeg; *.png; *.bmp)|*.jpg;*.jpeg;*.png;*.bmp|Tất cả tập tin (*.*)|*.*";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    txtCoverPath.Text = ofd.FileName;
                    LoadCoverImageToPictureBox(ofd.FileName);
                }
            }
        }

        private void LoadSelectedCoverImage()
        {
            if (bindingSource.Current is BookModel currentBook)
            {
                LoadCoverImageToPictureBox(currentBook.CoverPath);
            }
            else
            {
                picBookCover.Image = null;
            }
        }

        private void LoadCoverImageToPictureBox(string path)
        {
            try
            {
                if (!string.IsNullOrEmpty(path) && File.Exists(path))
                {
                    // Đọc qua FileStream/MemoryStream để không bị khóa file (File Lock)
                    byte[] bytes = File.ReadAllBytes(path);
                    using (MemoryStream ms = new MemoryStream(bytes))
                    {
                        picBookCover.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    picBookCover.Image = null;
                }
            }
            catch
            {
                picBookCover.Image = null;
            }
        }

        // ================= 2. XUẤT / NHẬP DỮ LIỆU FILE CSV =================
        private void ExportToCsv()
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Title = "Xuất dữ liệu báo cáo danh sách sách";
                sfd.Filter = "Tập tin CSV (*.csv)|*.csv|Tất cả tập tin (*.*)|*.*";
                sfd.FileName = $"BaoCaoSach_{DateTime.Now:yyyyMMdd_HHmmss}.csv";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        StringBuilder sb = new StringBuilder();
                        // Dòng tiêu đề
                        sb.AppendLine("Mã Sách,Tên Sách,Tác Giả,Thể Loại,Đơn Giá,Số Lượng,Thành Tiền,Ảnh Bìa");

                        foreach (var book in bookList)
                        {
                            string line = $"\"{book.BookId}\",\"{EscapeCsv(book.Title)}\",\"{EscapeCsv(book.Author)}\",\"{EscapeCsv(book.Category)}\",{book.Price},{book.Quantity},{book.TotalValue},\"{EscapeCsv(book.CoverPath)}\"";
                            sb.AppendLine(line);
                        }

                        File.WriteAllText(sfd.FileName, sb.ToString(), Encoding.UTF8);
                        MessageBox.Show("Xuất file CSV thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi khi xuất file: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void ImportFromCsv()
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Mở file dữ liệu CSV";
                ofd.Filter = "Tập tin CSV (*.csv)|*.csv|Tất cả tập tin (*.*)|*.*";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string[] lines = File.ReadAllLines(ofd.FileName, Encoding.UTF8);
                        if (lines.Length <= 1)
                        {
                            MessageBox.Show("File CSV không có dữ liệu!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        bookList.Clear();

                        // Đọc từ dòng thứ 2 (bỏ dòng header)
                        for (int i = 1; i < lines.Length; i++)
                        {
                            if (string.IsNullOrWhiteSpace(lines[i])) continue;

                            string[] parts = ParseCsvLine(lines[i]);
                            if (parts.Length >= 8)
                            {
                                bookList.Add(new BookModel
                                {
                                    BookId = parts[0],
                                    Title = parts[1],
                                    Author = parts[2],
                                    Category = parts[3],
                                    Price = decimal.TryParse(parts[4], out decimal p) ? p : 0,
                                    Quantity = int.TryParse(parts[5], out int q) ? q : 0,
                                    CoverPath = parts[7]
                                });
                            }
                        }

                        MessageBox.Show($"Nhập thành công {bookList.Count} đầu sách từ file CSV!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi đọc file CSV: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private string EscapeCsv(string str)
        {
            return str?.Replace("\"", "\"\"") ?? "";
        }

        private string[] ParseCsvLine(string line)
        {
            var pattern = @",(?=(?:[^""]*""[^""]*"")*[^""]*$)";
            var tokens = Regex.Split(line, pattern);
            for (int i = 0; i < tokens.Length; i++)
            {
                tokens[i] = tokens[i].Trim(' ', '"').Replace("\"\"", "\"");
            }
            return tokens;
        }

        // ================= 3. CẬP NHẬT STATUSSTRIP =================
        private void UpdateStatusStrip()
        {
            int totalBooks = bookList.Count;
            int totalCopies = bookList.Sum(b => b.Quantity);
            decimal totalValue = bookList.Sum(b => b.TotalValue);

            lblStatusTotalBooks.Text = $"Tổng số đầu sách: {totalBooks} (Tổng số lượng: {totalCopies})";
            lblStatusTotalValue.Text = $"Tổng giá trị kho: {totalValue:N0} VNĐ";
        }

        // ================= 4. RÀNG BUỘC KIỂM TRA DỮ LIỆU (ERRORPROVIDER) =================
        private bool ValidateData()
        {
            errorProvider1.Clear();
            bool isValid = true;

            // 1. Tên sách không được rỗng
            if (string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                errorProvider1.SetError(txtTitle, "Tên sách không được để trống.");
                isValid = false;
            }

            // 2. Tác giả không được rỗng
            if (string.IsNullOrWhiteSpace(txtAuthor.Text))
            {
                errorProvider1.SetError(txtAuthor, "Tên tác giả không được để trống.");
                isValid = false;
            }

            // 3. Đơn giá phải là số dương
            string rawPrice = txtPrice.Text.Replace(".", "").Replace(",", "").Trim();
            if (!decimal.TryParse(rawPrice, out decimal price) || price <= 0)
            {
                errorProvider1.SetError(txtPrice, "Đơn giá phải là số dương.");
                isValid = false;
            }

            // 4. Số lượng phải là số nguyên dương
            if (!int.TryParse(txtQuantity.Text.Trim(), out int qty) || qty <= 0)
            {
                errorProvider1.SetError(txtQuantity, "Số lượng phải là số nguyên dương.");
                isValid = false;
            }

            return isValid;
        }

        private void PrepareForNewBook()
        {
            bindingSource.AddNew();
            txtBookId.Text = GenerateBookId();
            cboCategory.SelectedIndex = 0;
            txtPrice.Text = "0";
            txtQuantity.Text = "0";
            txtCoverPath.Text = "";
            picBookCover.Image = null;
            txtTitle.Focus();
        }

        // ================= Các Nút Chức Năng CRUD =================
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateData()) return;

            bindingSource.EndEdit();
            MessageBox.Show("Thêm mới sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            PrepareForNewBook();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (bindingSource.Current == null)
            {
                MessageBox.Show("Vui lòng chọn sách cần sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!ValidateData()) return;

            bindingSource.EndEdit();
            bindingSource.ResetCurrentItem();
            MessageBox.Show("Cập nhật thông tin sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (bindingSource.Current == null)
            {
                MessageBox.Show("Vui lòng chọn sách cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa đầu sách này khỏi kho?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                bindingSource.RemoveCurrent();
                errorProvider1.Clear();
                MessageBox.Show("Đã xóa đầu sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            bindingSource.CancelEdit();
            errorProvider1.Clear();
            PrepareForNewBook();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim().ToLower();
            if (string.IsNullOrEmpty(keyword))
            {
                dgvBooks.DataSource = bindingSource;
            }
            else
            {
                var filteredList = bookList.Where(b =>
                    (b.BookId != null && b.BookId.ToLower().Contains(keyword)) ||
                    (b.Title != null && b.Title.ToLower().Contains(keyword)) ||
                    (b.Author != null && b.Author.ToLower().Contains(keyword)) ||
                    (b.Category != null && b.Category.ToLower().Contains(keyword))
                ).ToList();

                dgvBooks.DataSource = new BindingList<BookModel>(filteredList);
            }
        }
    }
}