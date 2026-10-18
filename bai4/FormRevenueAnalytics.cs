using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RevenueAnalytics
{
    public partial class formRevenueAnalytics : Form
    {
        // Token quản lý hủy tác vụ bất đồng bộ
        private CancellationTokenSource cts;

        public formRevenueAnalytics()
        {
            InitializeComponent();
            SetupDataGridView();

            cboBranch.SelectedIndex = 0;
            dtpFromDate.Value = DateTime.Now.AddMonths(-1);
            dtpToDate.Value = DateTime.Now;

            btnStatistic.Click += BtnStatistic_Click;
            btnCancel.Click += BtnCancel_Click;
        }

        private void SetupDataGridView()
        {
            dgvRevenueData.AutoGenerateColumns = false;
            dgvRevenueData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRevenueData.ReadOnly = true;
            dgvRevenueData.MultiSelect = false;
            dgvRevenueData.AllowUserToAddRows = false;

            dgvRevenueData.Columns.Clear();
            dgvRevenueData.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "TransactionId",
                HeaderText = "Mã Giao Dịch",
                Width = 120
            });
            dgvRevenueData.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "TransactionDate",
                HeaderText = "Ngày Giao Dịch",
                Width = 140,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy HH:mm" }
            });
            dgvRevenueData.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "BranchName",
                HeaderText = "Chi Nhánh",
                Width = 180
            });
            dgvRevenueData.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "CustomerName",
                HeaderText = "Tên Khách Hàng",
                Width = 180
            });
            dgvRevenueData.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Amount",
                HeaderText = "Số Tiền (VNĐ)",
                Width = 150,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "N0", Alignment = DataGridViewContentAlignment.MiddleRight }
            });
            dgvRevenueData.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "PaymentMethod",
                HeaderText = "Hình Thức TT",
                Width = 130
            });
        }

        // ================= 1. XỬ LÝ BẤT ĐỒNG BỘ (ASYNC/AWAIT & TASK.RUN) =================
        private async void BtnStatistic_Click(object sender, EventArgs e)
        {
            // Reset giao diện trước khi chạy
            dgvRevenueData.DataSource = null;
            pgbLoading.Value = 0;
            lblProcessingStatus.Text = "Đang khởi tạo kết nối CSDL và tổng hợp dữ liệu...";

            btnStatistic.Enabled = false;
            btnCancel.Enabled = true;

            // Khởi tạo CancellationTokenSource mới cho mỗi lần thực thi
            cts = new CancellationTokenSource();

            // Khai báo Progress<T> để cập nhật UI mượt mà từ Background Thread
            var progress = new Progress<int>(percent =>
            {
                pgbLoading.Value = percent;
                lblProcessingStatus.Text = $"Đang truy xuất CSDL... {percent}% (Giao diện vẫn phản hồi mượt mà)";
            });

            string selectedBranch = cboBranch.SelectedItem?.ToString();
            DateTime fromDate = dtpFromDate.Value;
            DateTime toDate = dtpToDate.Value;

            try
            {
                // Đẩy công việc tổng hợp nặng xuống Background Thread bằng Task.Run
                // Giúp UI Thread không bị đơ / Not Responding
                List<TransactionModel> resultData = await Task.Run(() =>
                    FetchHeavyRevenueData(selectedBranch, fromDate, toDate, progress, cts.Token),
                    cts.Token
                );

                // Sau khi hoàn thành, gán dữ liệu lên Grid trên UI Thread
                dgvRevenueData.DataSource = new BindingList<TransactionModel>(resultData);
                lblProcessingStatus.Text = $"Hoàn tất! Tổng số giao dịch truy xuất được: {resultData.Count}";
                MessageBox.Show($"Thống kê doanh thu thành công! Tìm thấy {resultData.Count} giao dịch.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (OperationCanceledException)
            {
                // Bắt ngoại lệ khi người dùng nhấn [Hủy Thao Tác]
                pgbLoading.Value = 0;
                lblProcessingStatus.Text = "Đã hủy thao tác thống kê bởi người dùng!";
                MessageBox.Show("Đã hủy thao tác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                lblProcessingStatus.Text = "Xảy ra lỗi trong quá trình xử lý!";
                MessageBox.Show($"Lỗi truy xuất dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Cập nhật lại trạng thái nút bấm
                btnStatistic.Enabled = true;
                btnCancel.Enabled = false;

                cts?.Dispose();
                cts = null;
            }
        }

        // ================= 2. HỦY TÁC VỤ (CANCELLATION) =================
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            if (cts != null && !cts.IsCancellationRequested)
            {
                lblProcessingStatus.Text = "Đang gửi yêu cầu hủy tiến trình...";
                cts.Cancel(); // Ngắt tiến trình ngầm một cách an toàn
            }
        }

        // ================= GIẢ LẬP TÁC VỤ TRUY XUẤT NẶNG MẤT 5 GIÂY =================
        private List<TransactionModel> FetchHeavyRevenueData(
            string branch,
            DateTime fromDate,
            DateTime toDate,
            IProgress<int> progress,
            CancellationToken token)
        {
            List<TransactionModel> list = new List<TransactionModel>();
            Random rand = new Random();
            string[] customers = { "Nguyễn Văn A", "Trần Thị B", "Lê Hoàng C", "Phạm Minh D", "Vũ Tuyết E" };
            string[] methods = { "Tiền mặt", "Chuyển khoản", "Thẻ tín dụng", "Ví MoMo" };

            // Giả lập tiến trình tính toán/truy xuất gồm 50 bước (~ 5 giây)
            int totalSteps = 50;
            for (int i = 1; i <= totalSteps; i++)
            {
                // Kiểm tra nếu người dùng đã bấm nút Hủy
                token.ThrowIfCancellationRequested();

                // Giả lập độ trễ truy xuất CSDL nặng (100ms mỗi bước)
                Thread.Sleep(100);

                // Giả lập tạo bản ghi ngẫu nhiên
                list.Add(new TransactionModel
                {
                    TransactionId = $"GD{1000 + i}",
                    TransactionDate = fromDate.AddDays(rand.Next(0, Math.Max(1, (toDate - fromDate).Days))),
                    BranchName = branch == "Tất cả chi nhánh" ? $"Chi nhánh {rand.Next(1, 5)}" : branch,
                    CustomerName = customers[rand.Next(customers.Length)],
                    Amount = rand.Next(10, 500) * 10000,
                    PaymentMethod = methods[rand.Next(methods.Length)]
                });

                // Báo cáo tiến độ về UI Thread qua IProgress<T>
                int percentComplete = (i * 100) / totalSteps;
                progress?.Report(percentComplete);
            }

            return list;
        }
    }
}