namespace CryptoMonitor
{
    partial class formCryptoStockTicker
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
            this.btnStart = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblBTCPrice = new System.Windows.Forms.Label();
            this.dgvHistoryLog = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblLastUpdate = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblSyncCount = new System.Windows.Forms.ToolStripStatusLabel();

            ((System.ComponentModel.ISupportInitialize)(this.dgvHistoryLog)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();

            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnStart.Location = new System.Drawing.Point(12, 12);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(150, 40);
            this.btnStart.Text = "▶ Bắt đầu Giám sát";
            this.btnStart.UseVisualStyleBackColor = true;

            // 
            // btnPause
            // 
            this.btnPause.Enabled = false;
            this.btnPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnPause.Location = new System.Drawing.Point(170, 12);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(150, 40);
            this.btnPause.Text = "⏸ Tạm dừng";
            this.btnPause.UseVisualStyleBackColor = true;

            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular);
            this.lblTitle.Location = new System.Drawing.Point(12, 70);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Text = "TỶ GIÁ BTC/USD HIỆN TẠI:";

            // 
            // lblBTCPrice
            // 
            this.lblBTCPrice.AutoSize = true;
            this.lblBTCPrice.Font = new System.Drawing.Font("Consolas", 28F, System.Drawing.FontStyle.Bold);
            this.lblBTCPrice.Location = new System.Drawing.Point(12, 100);
            this.lblBTCPrice.Name = "lblBTCPrice";
            this.lblBTCPrice.Text = "$0.00";

            // 
            // dgvHistoryLog
            // 
            this.dgvHistoryLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistoryLog.Location = new System.Drawing.Point(12, 160);
            this.dgvHistoryLog.Name = "dgvHistoryLog";
            this.dgvHistoryLog.Size = new System.Drawing.Size(560, 260);

            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblLastUpdate,
            this.lblSyncCount});
            this.statusStrip1.Location = new System.Drawing.Point(0, 439);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(584, 22);

            // 
            // lblLastUpdate
            // 
            this.lblLastUpdate.Name = "lblLastUpdate";
            this.lblLastUpdate.Size = new System.Drawing.Size(200, 17);
            this.lblLastUpdate.Text = "Lần cập nhật cuối: --:--:--";

            // 
            // lblSyncCount
            // 
            this.lblSyncCount.Name = "lblSyncCount";
            this.lblSyncCount.Size = new System.Drawing.Size(150, 17);
            this.lblSyncCount.Text = " | Số lượt đồng bộ: 0";

            // 
            // frmCryptoStockTicker
            // 
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dgvHistoryLog);
            this.Controls.Add(this.lblBTCPrice);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnStart);
            this.Name = "frmCryptoStockTicker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giám Sát Tỷ Giá Crypto/Stock Thời Gian Thực";

            ((System.ComponentModel.ISupportInitialize)(this.dgvHistoryLog)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblBTCPrice;
        private System.Windows.Forms.DataGridView dgvHistoryLog;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblLastUpdate;
        private System.Windows.Forms.ToolStripStatusLabel lblSyncCount;
    }
}