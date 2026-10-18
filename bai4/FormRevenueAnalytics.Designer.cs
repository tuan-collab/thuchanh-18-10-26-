namespace RevenueAnalytics
{
    partial class formRevenueAnalytics
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
            this.gbCriteria = new System.Windows.Forms.GroupBox();
            this.lblFromDate = new System.Windows.Forms.Label();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.lblToDate = new System.Windows.Forms.Label();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.lblBranch = new System.Windows.Forms.Label();
            this.cboBranch = new System.Windows.Forms.ComboBox();
            this.btnStatistic = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();

            this.gbStatus = new System.Windows.Forms.GroupBox();
            this.pgbLoading = new System.Windows.Forms.ProgressBar();
            this.lblProcessingStatus = new System.Windows.Forms.Label();

            this.dgvRevenueData = new System.Windows.Forms.DataGridView();

            this.gbCriteria.SuspendLayout();
            this.gbStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRevenueData)).BeginInit();
            this.SuspendLayout();

            // 
            // gbCriteria (Khu vực tiêu chí)
            // 
            this.gbCriteria.Controls.Add(this.lblFromDate);
            this.gbCriteria.Controls.Add(this.dtpFromDate);
            this.gbCriteria.Controls.Add(this.lblToDate);
            this.gbCriteria.Controls.Add(this.dtpToDate);
            this.gbCriteria.Controls.Add(this.lblBranch);
            this.gbCriteria.Controls.Add(this.cboBranch);
            this.gbCriteria.Controls.Add(this.btnStatistic);
            this.gbCriteria.Controls.Add(this.btnCancel);
            this.gbCriteria.Location = new System.Drawing.Point(12, 12);
            this.gbCriteria.Size = new System.Drawing.Size(960, 110);
            this.gbCriteria.Text = "Tiêu chí thống kê";

            // lblFromDate & dtpFromDate
            this.lblFromDate.Text = "Từ ngày:";
            this.lblFromDate.Location = new System.Drawing.Point(15, 30);
            this.lblFromDate.AutoSize = true;
            this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFromDate.Location = new System.Drawing.Point(80, 27);
            this.dtpFromDate.Size = new System.Drawing.Size(130, 22);

            // lblToDate & dtpToDate
            this.lblToDate.Text = "Đến ngày:";
            this.lblToDate.Location = new System.Drawing.Point(230, 30);
            this.lblToDate.AutoSize = true;
            this.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpToDate.Location = new System.Drawing.Point(300, 27);
            this.dtpToDate.Size = new System.Drawing.Size(130, 22);

            // lblBranch & cboBranch
            this.lblBranch.Text = "Chi nhánh:";
            this.lblBranch.Location = new System.Drawing.Point(450, 30);
            this.lblBranch.AutoSize = true;
            this.cboBranch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBranch.Items.AddRange(new object[] {
                "Tất cả chi nhánh",
                "Chi nhánh Hà Nội",
                "Chi nhánh TP. Hồ Chí Minh",
                "Chi nhánh Đà Nẵng",
                "Chi nhánh Cần Thơ"
            });
            this.cboBranch.Location = new System.Drawing.Point(525, 27);
            this.cboBranch.Size = new System.Drawing.Size(200, 24);

            // Buttons
            this.btnStatistic.Text = "📊 Thống Kê Doanh Thu";
            this.btnStatistic.Location = new System.Drawing.Point(200, 65);
            this.btnStatistic.Size = new System.Drawing.Size(180, 35);

            this.btnCancel.Text = "⛔ Hủy Thao Tác";
            this.btnCancel.Location = new System.Drawing.Point(400, 65);
            this.btnCancel.Size = new System.Drawing.Size(150, 35);
            this.btnCancel.Enabled = false; // Mặc định ẩn nút hủy khi chưa chạy

            // 
            // gbStatus (Khu vực trạng thái tiến trình)
            // 
            this.gbStatus.Controls.Add(this.pgbLoading);
            this.gbStatus.Controls.Add(this.lblProcessingStatus);
            this.gbStatus.Location = new System.Drawing.Point(12, 130);
            this.gbStatus.Size = new System.Drawing.Size(960, 75);
            this.gbStatus.Text = "Trạng thái xử lý hệ thống";

            this.pgbLoading.Location = new System.Drawing.Point(15, 25);
            this.pgbLoading.Size = new System.Drawing.Size(930, 20);

            this.lblProcessingStatus.Text = "Sẵn sàng thống kê.";
            this.lblProcessingStatus.Location = new System.Drawing.Point(15, 50);
            this.lblProcessingStatus.AutoSize = true;

            // 
            // dgvRevenueData (Khu vực hiển thị kết quả)
            // 
            this.dgvRevenueData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRevenueData.Location = new System.Drawing.Point(12, 215);
            this.dgvRevenueData.Size = new System.Drawing.Size(960, 330);

            // 
            // Form Setup
            // 
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.dgvRevenueData);
            this.Controls.Add(this.gbStatus);
            this.Controls.Add(this.gbCriteria);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bảng Điều Khiển Thống Kê Doanh Thu Multi-Threading";

            this.gbCriteria.ResumeLayout(false);
            this.gbCriteria.PerformLayout();
            this.gbStatus.ResumeLayout(false);
            this.gbStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRevenueData)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox gbCriteria;
        private System.Windows.Forms.Label lblFromDate;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.Label lblToDate;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.Label lblBranch;
        private System.Windows.Forms.ComboBox cboBranch;
        private System.Windows.Forms.Button btnStatistic;
        private System.Windows.Forms.Button btnCancel;

        private System.Windows.Forms.GroupBox gbStatus;
        private System.Windows.Forms.ProgressBar pgbLoading;
        private System.Windows.Forms.Label lblProcessingStatus;

        private System.Windows.Forms.DataGridView dgvRevenueData;
    }
}