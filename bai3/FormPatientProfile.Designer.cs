namespace HospitalManagement
{
    partial class formPatientProfiles
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
            this.dgvPatients = new System.Windows.Forms.DataGridView();
            this.gbInfo = new System.Windows.Forms.GroupBox();
            this.lblId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.cboGender = new System.Windows.Forms.ComboBox();
            this.lblDept = new System.Windows.Forms.Label();
            this.cboDept = new System.Windows.Forms.ComboBox();
            this.lblDiagnosis = new System.Windows.Forms.Label();
            this.txtDiagnosis = new System.Windows.Forms.TextBox();

            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();

            this.gbInfo.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatients)).BeginInit();
            this.SuspendLayout();

            // gbInfo
            this.gbInfo.Controls.Add(this.lblId);
            this.gbInfo.Controls.Add(this.txtId);
            this.gbInfo.Controls.Add(this.lblName);
            this.gbInfo.Controls.Add(this.txtName);
            this.gbInfo.Controls.Add(this.lblAge);
            this.gbInfo.Controls.Add(this.txtAge);
            this.gbInfo.Controls.Add(this.lblGender);
            this.gbInfo.Controls.Add(this.cboGender);
            this.gbInfo.Controls.Add(this.lblDept);
            this.gbInfo.Controls.Add(this.cboDept);
            this.gbInfo.Controls.Add(this.lblDiagnosis);
            this.gbInfo.Controls.Add(this.txtDiagnosis);
            this.gbInfo.Location = new System.Drawing.Point(12, 12);
            this.gbInfo.Size = new System.Drawing.Size(760, 130);
            this.gbInfo.Text = "Thông tin hồ sơ bệnh nhân";

            this.lblId.Text = "Mã BN:";
            this.lblId.Location = new System.Drawing.Point(15, 30);
            this.lblId.AutoSize = true;
            this.txtId.Location = new System.Drawing.Point(70, 27);
            this.txtId.Size = new System.Drawing.Size(120, 22);

            this.lblName.Text = "Họ và tên:";
            this.lblName.Location = new System.Drawing.Point(210, 30);
            this.lblName.AutoSize = true;
            this.txtName.Location = new System.Drawing.Point(280, 27);
            this.txtName.Size = new System.Drawing.Size(180, 22);

            this.lblAge.Text = "Tuổi:";
            this.lblAge.Location = new System.Drawing.Point(480, 30);
            this.lblAge.AutoSize = true;
            this.txtAge.Location = new System.Drawing.Point(525, 27);
            this.txtAge.Size = new System.Drawing.Size(60, 22);

            this.lblGender.Text = "Giới tính:";
            this.lblGender.Location = new System.Drawing.Point(600, 30);
            this.lblGender.AutoSize = true;
            this.cboGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGender.Items.AddRange(new object[] { "Nam", "Nữ" });
            this.cboGender.Location = new System.Drawing.Point(665, 27);
            this.cboGender.Size = new System.Drawing.Size(80, 24);

            this.lblDept.Text = "Khoa:";
            this.lblDept.Location = new System.Drawing.Point(15, 75);
            this.lblDept.AutoSize = true;
            this.cboDept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDept.Items.AddRange(new object[] { "Khoa Nội", "Khoa Ngoại", "Khoa Cấp cứu", "Khoa Tim mạch", "Khoa Nhi" });
            this.cboDept.Location = new System.Drawing.Point(70, 72);
            this.cboDept.Size = new System.Drawing.Size(180, 24);

            this.lblDiagnosis.Text = "Chẩn đoán:";
            this.lblDiagnosis.Location = new System.Drawing.Point(270, 75);
            this.lblDiagnosis.AutoSize = true;
            this.txtDiagnosis.Location = new System.Drawing.Point(345, 72);
            this.txtDiagnosis.Size = new System.Drawing.Size(400, 22);

            // pnlButtons
            this.pnlButtons.Controls.Add(this.btnAdd);
            this.pnlButtons.Controls.Add(this.btnEdit);
            this.pnlButtons.Controls.Add(this.btnDelete);
            this.pnlButtons.Location = new System.Drawing.Point(12, 150);
            this.pnlButtons.Size = new System.Drawing.Size(760, 40);

            this.btnAdd.Text = "Thêm bệnh nhân";
            this.btnAdd.Location = new System.Drawing.Point(180, 5);
            this.btnAdd.Size = new System.Drawing.Size(120, 30);

            this.btnEdit.Text = "Cập nhật";
            this.btnEdit.Location = new System.Drawing.Point(320, 5);
            this.btnEdit.Size = new System.Drawing.Size(120, 30);

            this.btnDelete.Text = "Xóa hồ sơ";
            this.btnDelete.Location = new System.Drawing.Point(460, 5);
            this.btnDelete.Size = new System.Drawing.Size(120, 30);

            // dgvPatients
            this.dgvPatients.Location = new System.Drawing.Point(12, 200);
            this.dgvPatients.Size = new System.Drawing.Size(760, 240);

            // Form
            this.ClientSize = new System.Drawing.Size(784, 451);
            this.Controls.Add(this.dgvPatients);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.gbInfo);
            this.Text = "Quản Lý Hồ Sơ Bệnh Nhân";

            this.gbInfo.ResumeLayout(false);
            this.gbInfo.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatients)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox gbInfo;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.ComboBox cboGender;
        private System.Windows.Forms.Label lblDept;
        private System.Windows.Forms.ComboBox cboDept;
        private System.Windows.Forms.Label lblDiagnosis;
        private System.Windows.Forms.TextBox txtDiagnosis;

        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;

        private System.Windows.Forms.DataGridView dgvPatients;
    }
}