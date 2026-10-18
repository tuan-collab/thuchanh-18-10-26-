namespace HospitalManagement
{
    partial class formDoctorSchedule
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
            this.dgvDoctors = new System.Windows.Forms.DataGridView();
            this.lblTitle = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.dgvDoctors)).BeginInit();
            this.SuspendLayout();

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(12, 15);
            this.lblTitle.Text = "LỊCH TRỰC CÁC BÁC SĨ TRONG NGÀY";

            // dgvDoctors
            this.dgvDoctors.Location = new System.Drawing.Point(12, 50);
            this.dgvDoctors.Size = new System.Drawing.Size(760, 380);

            // Form
            this.ClientSize = new System.Drawing.Size(784, 441);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.dgvDoctors);
            this.Text = "Danh Mục Lịch Trực Bác Sĩ";

            ((System.ComponentModel.ISupportInitialize)(this.dgvDoctors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvDoctors;
    }
}