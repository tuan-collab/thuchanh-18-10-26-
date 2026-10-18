using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptoMonitor
{
    public partial class formCryptoStockTicker : Form
    {
        private bool isMonitoring = false;
        private decimal currentPrice = 64000.00m; // Giá giả lập ban đầu
        private int syncCount = 0;
        private BindingList<PriceLogModel> historyLogs;
        private Random random;

        public formCryptoStockTicker()
        {
            InitializeComponent();
            random = new Random();
            historyLogs = new BindingList<PriceLogModel>();

            SetupDataGridView();

            btnStart.Click += BtnStart_Click;
            btnPause.Click += BtnPause_Click;

            // Hiển thị giá mặc định ban đầu
            lblBTCPrice.Text = $"${currentPrice:N2}";
        }

        private void SetupDataGridView()
        {
            dgvHistoryLog.AutoGenerateColumns = false;
            dgvHistoryLog.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHistoryLog.ReadOnly = true;
            dgvHistoryLog.AllowUserToAddRows = false;

            dgvHistoryLog.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "LogTime", HeaderText = "Thời Gian", Width = 150 });
            dgvHistoryLog.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Price", HeaderText = "Mức Giá (USD)", Width = 200, DefaultCellStyle = new DataGridViewCellStyle { Format = "N2" } });
            dgvHistoryLog.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Trend", HeaderText = "Biến Động", Width = 150 });

            dgvHistoryLog.DataSource = historyLogs;
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            isMonitoring = true;
            btnStart.Enabled = false;
            btnPause.Enabled = true;

            // Khởi chạy tiến trình ngầm (Background Thread) tách biệt khỏi UI
            Task.Run(() => MonitorPricingLoop());
        }

        private void BtnPause_Click(object sender, EventArgs e)
        {
            // Tắt cờ, Background Thread sẽ tự động thoát vòng lặp
            isMonitoring = false;
            btnStart.Enabled = true;
            btnPause.Enabled = false;
        }

        /// <summary>
        /// TIẾN TRÌNH CHẠY NGẦM (BACKGROUND THREAD)
        /// Tuyệt đối KHÔNG cập nhật UI trực tiếp trong hàm này.
        /// </summary>
        private void MonitorPricingLoop()
        {
            while (isMonitoring)
            {
                // Giả lập biến động giá từ -50$ đến +50$
                decimal fluctuation = (decimal)(random.NextDouble() * 100 - 50);
                decimal newPrice = currentPrice + fluctuation;

                // Gửi dữ liệu về Main UI Thread để cập nhật an toàn
                UpdateUserInterfaceSafely(newPrice, DateTime.Now);

                // Dừng 2 giây cho lần quét tiếp theo
                Thread.Sleep(2000);
            }
        }

        /// <summary>
        /// KỸ THUẬT THREAD SAFETY (CROSS-THREAD OPERATION)
        /// Cập nhật mọi control giao diện thông qua Invoke/InvokeRequired
        /// </summary>
        private void UpdateUserInterfaceSafely(decimal newPrice, DateTime updateTime)
        {
            // BƯỚC 1: Kiểm tra xem luồng gọi hàm có phải là UI Thread không?
            if (this.InvokeRequired)
            {
                // BƯỚC 2: Nếu không phải (đang ở Background Thread), đẩy Action về UI Thread
                this.Invoke(new Action(() => UpdateUserInterfaceSafely(newPrice, updateTime)));
                return;
            }

            // ==============================================================
            // TỪ DÒNG NÀY TRỞ ĐI, CODE CHẮC CHẮN ĐANG CHẠY TRÊN MAIN UI THREAD
            // THOẢI MÁI CẬP NHẬT GIAO DIỆN MÀ KHÔNG SỢ LỖI
            // ==============================================================

            string trend = "Đi ngang";

            // Xử lý đổi màu Label
            if (newPrice > currentPrice)
            {
                lblBTCPrice.ForeColor = Color.Green;
                trend = "Tăng ▲";
            }
            else if (newPrice < currentPrice)
            {
                lblBTCPrice.ForeColor = Color.Red;
                trend = "Giảm ▼";
            }

            // Gán lại giá trị
            currentPrice = newPrice;
            syncCount++;

            // 1. Cập nhật Label Giá
            lblBTCPrice.Text = $"${currentPrice:N2}";

            // 2. Thêm vào DataGridView (Luôn đẩy lên đầu danh sách)
            historyLogs.Insert(0, new PriceLogModel
            {
                LogTime = updateTime.ToString("HH:mm:ss"),
                Price = currentPrice,
                Trend = trend
            });

            // 3. Cập nhật StatusStrip
            lblLastUpdate.Text = $"Lần cập nhật cuối: {updateTime:HH:mm:ss}";
            lblSyncCount.Text = $" | Số lượt đồng bộ: {syncCount}";
        }
    }
}