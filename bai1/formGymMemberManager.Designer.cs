namespace GymManagement
{
    partial class formGymMemberManager
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gbInfo = new System.Windows.Forms.GroupBox();
            this.lblMemberId = new System.Windows.Forms.Label();
            this.txtMemberId = new System.Windows.Forms.TextBox();
            this.lblFullName = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblPackage = new System.Windows.Forms.Label();
            this.cboPackage = new System.Windows.Forms.ComboBox();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblFee = new System.Windows.Forms.Label();
            this.txtFee = new System.Windows.Forms.TextBox();

            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();

            this.dgvMembers = new System.Windows.Forms.DataGridView();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);

            this.gbInfo.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();

            // 
            // gbInfo
            // 
            this.gbInfo.Controls.Add(this.lblMemberId);
            this.gbInfo.Controls.Add(this.txtMemberId);
            this.gbInfo.Controls.Add(this.lblFullName);
            this.gbInfo.Controls.Add(this.txtFullName);
            this.gbInfo.Controls.Add(this.lblPhone);
            this.gbInfo.Controls.Add(this.txtPhone);
            this.gbInfo.Controls.Add(this.lblPackage);
            this.gbInfo.Controls.Add(this.cboPackage);
            this.gbInfo.Controls.Add(this.lblStartDate);
            this.gbInfo.Controls.Add(this.dtpStartDate);
            this.gbInfo.Controls.Add(this.lblFee);
            this.gbInfo.Controls.Add(this.txtFee);
            this.gbInfo.Location = new System.Drawing.Point(12, 12);
            this.gbInfo.Size = new System.Drawing.Size(910, 140);
            this.gbInfo.Text = "Thông tin hội viên";

            // lblMemberId & txtMemberId
            this.lblMemberId.AutoSize = true;
            this.lblMemberId.Location = new System.Drawing.Point(20, 30);
            this.lblMemberId.Text = "Mã hội viên:";
            this.txtMemberId.Location = new System.Drawing.Point(110, 27);
            this.txtMemberId.Size = new System.Drawing.Size(160, 22);
            this.txtMemberId.ReadOnly = true;

            // lblFullName & txtFullName
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(310, 30);
            this.lblFullName.Text = "Họ và tên:";
            this.txtFullName.Location = new System.Drawing.Point(400, 27);
            this.txtFullName.Size = new System.Drawing.Size(180, 22);

            // lblPhone & txtPhone
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(610, 30);
            this.lblPhone.Text = "Số điện thoại:";
            this.txtPhone.Location = new System.Drawing.Point(710, 27);
            this.txtPhone.Size = new System.Drawing.Size(170, 22);

            // lblPackage & cboPackage
            this.lblPackage.AutoSize = true;
            this.lblPackage.Location = new System.Drawing.Point(20, 75);
            this.lblPackage.Text = "Gói tập:";
            this.cboPackage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPackage.FormattingEnabled = true;
            this.cboPackage.Items.AddRange(new object[] { "Theo tháng", "6 tháng", "1 năm" });
            this.cboPackage.Location = new System.Drawing.Point(110, 72);
            this.cboPackage.Size = new System.Drawing.Size(160, 24);

            // lblStartDate & dtpStartDate
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(310, 75);
            this.lblStartDate.Text = "Ngày đăng ký:";
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartDate.Location = new System.Drawing.Point(400, 72);
            this.dtpStartDate.Size = new System.Drawing.Size(180, 22);

            // lblFee & txtFee
            this.lblFee.AutoSize = true;
            this.lblFee.Location = new System.Drawing.Point(610, 75);
            this.lblFee.Text = "Phí dịch vụ:";
            this.txtFee.Location = new System.Drawing.Point(710, 72);
            this.txtFee.Size = new System.Drawing.Size(170, 22);

            // 
            // pnlButtons
            // 
            this.pnlButtons.Controls.Add(this.btnAdd);
            this.pnlButtons.Controls.Add(this.btnEdit);
            this.pnlButtons.Controls.Add(this.btnDelete);
            this.pnlButtons.Controls.Add(this.btnReset);
            this.pnlButtons.Location = new System.Drawing.Point(12, 160);
            this.pnlButtons.Size = new System.Drawing.Size(910, 45);

            // Buttons
            this.btnAdd.Location = new System.Drawing.Point(180, 5);
            this.btnAdd.Size = new System.Drawing.Size(110, 35);
            this.btnAdd.Text = "Thêm mới";

            this.btnEdit.Location = new System.Drawing.Point(310, 5);
            this.btnEdit.Size = new System.Drawing.Size(110, 35);
            this.btnEdit.Text = "Sửa thông tin";

            this.btnDelete.Location = new System.Drawing.Point(440, 5);
            this.btnDelete.Size = new System.Drawing.Size(110, 35);
            this.btnDelete.Text = "Xóa hội viên";

            this.btnReset.Location = new System.Drawing.Point(570, 5);
            this.btnReset.Size = new System.Drawing.Size(110, 35);
            this.btnReset.Text = "Làm mới";

            // 
            // dgvMembers
            // 
            this.dgvMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMembers.Location = new System.Drawing.Point(12, 215);
            this.dgvMembers.Size = new System.Drawing.Size(910, 325);

            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;

            // 
            // frmGymMemberManager
            // 
            this.ClientSize = new System.Drawing.Size(934, 553);
            this.Controls.Add(this.dgvMembers);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.gbInfo);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hệ Thống Quản Lý Dịch Vụ Phòng Gym & Hội Viên";

            this.gbInfo.ResumeLayout(false);
            this.gbInfo.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox gbInfo;
        private System.Windows.Forms.Label lblMemberId;
        private System.Windows.Forms.TextBox txtMemberId;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblPackage;
        private System.Windows.Forms.ComboBox cboPackage;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label lblFee;
        private System.Windows.Forms.TextBox txtFee;

        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnReset;

        private System.Windows.Forms.DataGridView dgvMembers;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}