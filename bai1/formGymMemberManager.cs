using System;
using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace GymManagement
{
    public partial class formGymMemberManager : Form
    {
        private BindingList<MemberModel> memberList;
        private BindingSource bindingSource;
        private int memberCounter = 1;

        public formGymMemberManager()
        {
            InitializeComponent();

            // Gán sự kiện Click cho nút bấm
            btnAdd.Click += BtnAdd_Click;
            btnEdit.Click += BtnEdit_Click;
            btnDelete.Click += BtnDelete_Click;
            btnReset.Click += BtnReset_Click;

            SetupDataGridView();
            SetupDataBinding();
            LoadSampleData();
            PrepareForNewMember();
        }

        private void SetupDataGridView()
        {
            // Yêu cầu 1: Cấu hình DataGridView bằng Code
            dgvMembers.AutoGenerateColumns = false;
            dgvMembers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMembers.ReadOnly = true;
            dgvMembers.MultiSelect = false;
            dgvMembers.AllowUserToAddRows = false;

            dgvMembers.Columns.Clear();
            dgvMembers.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "MemberId",
                HeaderText = "Mã HV",
                Width = 90
            });
            dgvMembers.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "FullName",
                HeaderText = "Tên hội viên",
                Width = 200
            });
            dgvMembers.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Phone",
                HeaderText = "SĐT",
                Width = 120
            });
            dgvMembers.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Package",
                HeaderText = "Gói tập",
                Width = 130
            });
            dgvMembers.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "StartDate",
                HeaderText = "Ngày ĐK",
                Width = 120,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy" }
            });
            dgvMembers.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Fee",
                HeaderText = "Phí dịch vụ",
                Width = 150,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "N0" }
            });
        }

        private void SetupDataBinding()
        {
            memberList = new BindingList<MemberModel>();
            bindingSource = new BindingSource { DataSource = memberList };
            dgvMembers.DataSource = bindingSource;

            // Ràng buộc dữ liệu 2 chiều tự động tới các Control
            txtMemberId.DataBindings.Add("Text", bindingSource, "MemberId", true, DataSourceUpdateMode.OnPropertyChanged);
            txtFullName.DataBindings.Add("Text", bindingSource, "FullName", true, DataSourceUpdateMode.OnPropertyChanged);
            txtPhone.DataBindings.Add("Text", bindingSource, "Phone", true, DataSourceUpdateMode.OnPropertyChanged);
            cboPackage.DataBindings.Add("Text", bindingSource, "Package", true, DataSourceUpdateMode.OnPropertyChanged);
            dtpStartDate.DataBindings.Add("Value", bindingSource, "StartDate", true, DataSourceUpdateMode.OnPropertyChanged);

            Binding feeBinding = new Binding("Text", bindingSource, "Fee", true, DataSourceUpdateMode.OnPropertyChanged, 0, "N0");
            txtFee.DataBindings.Add(feeBinding);
        }

        private void LoadSampleData()
        {
            memberList.Add(new MemberModel
            {
                MemberId = GenerateMemberId(),
                FullName = "Nguyễn Văn A",
                Phone = "0901234567",
                Package = "Theo tháng",
                StartDate = DateTime.Now.AddDays(-10),
                Fee = 500000
            });

            memberList.Add(new MemberModel
            {
                MemberId = GenerateMemberId(),
                FullName = "Trần Thị B",
                Phone = "0912345678",
                Package = "6 tháng",
                StartDate = DateTime.Now.AddDays(-30),
                Fee = 2700000
            });
        }

        private string GenerateMemberId()
        {
            return $"HV{memberCounter++:D3}";
        }

        private bool ValidateData()
        {
            errorProvider.Clear();
            bool isValid = true;

            // 1. Kiểm tra Họ và tên (không rỗng, không chứa ký tự đặc biệt)
            string namePattern = @"^[\p{L}\s]+$";
            if (string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                errorProvider.SetError(txtFullName, "Tên hội viên không được để trống.");
                isValid = false;
            }
            else if (!Regex.IsMatch(txtFullName.Text.Trim(), namePattern))
            {
                errorProvider.SetError(txtFullName, "Tên hội viên không được chứa ký tự đặc biệt hoặc chữ số.");
                isValid = false;
            }

            // 2. Kiểm tra Số điện thoại (10 chữ số)
            if (!Regex.IsMatch(txtPhone.Text.Trim(), @"^\d{10}$"))
            {
                errorProvider.SetError(txtPhone, "Số điện thoại phải đúng 10 chữ số.");
                isValid = false;
            }

            // 3. Kiểm tra Phí dịch vụ (Số nguyên dương)
            string rawFee = txtFee.Text.Replace(".", "").Replace(",", "").Trim();
            if (!long.TryParse(rawFee, out long feeValue) || feeValue <= 0)
            {
                errorProvider.SetError(txtFee, "Phí dịch vụ phải là số nguyên dương.");
                isValid = false;
            }

            return isValid;
        }

        private void PrepareForNewMember()
        {
            bindingSource.AddNew();
            txtMemberId.Text = GenerateMemberId();
            cboPackage.SelectedIndex = 0;
            dtpStartDate.Value = DateTime.Now;
            txtFee.Text = "0";
            txtFullName.Focus();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateData()) return;

            bindingSource.EndEdit();
            MessageBox.Show("Thêm mới hội viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            PrepareForNewMember();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (bindingSource.Current == null)
            {
                MessageBox.Show("Vui lòng chọn hội viên cần sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!ValidateData()) return;

            bindingSource.EndEdit();
            bindingSource.ResetCurrentItem(); // Đồng bộ ngay lập tức lên DataGridView
            MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (bindingSource.Current == null)
            {
                MessageBox.Show("Vui lòng chọn hội viên cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult confirm = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa hội viên này?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirm == DialogResult.Yes)
            {
                bindingSource.RemoveCurrent();
                errorProvider.Clear();
                MessageBox.Show("Đã xóa hội viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            bindingSource.CancelEdit();
            errorProvider.Clear();
            PrepareForNewMember();
        }
    }
}