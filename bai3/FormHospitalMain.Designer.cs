namespace HospitalManagement
{
    partial class formHospitalMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuSystem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.menuReload = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();

            this.menuManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPatients = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDoctors = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDepartments = new System.Windows.Forms.ToolStripMenuItem();

            this.menuWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCascade = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTileHorizontal = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTileVertical = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuCloseAll = new System.Windows.Forms.ToolStripMenuItem();

            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatusUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.pbarStatus = new System.Windows.Forms.ToolStripProgressBar();
            this.lblStatusTime = new System.Windows.Forms.ToolStripStatusLabel();

            this.timerClock = new System.Windows.Forms.Timer(this.components);

            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();

            // 
            // MenuStrip
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.menuSystem,
                this.menuManagement,
                this.menuWindow
            });
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1184, 24);

            // Menu Hệ thống
            this.menuSystem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.menuLogout,
                this.menuReload,
                this.toolStripSeparator1,
                this.menuExit
            });
            this.menuSystem.Text = "&Hệ thống";

            this.menuLogout.Text = "&Đăng xuất";
            this.menuReload.Text = "&Nạp lại dữ liệu";
            this.menuExit.Text = "T&hoát";

            // Menu Quản lý
            this.menuManagement.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.menuPatients,
                this.menuDoctors,
                this.menuDepartments
            });
            this.menuManagement.Text = "&Quản lý";

            this.menuPatients.Text = "&Hồ sơ Bệnh nhân";
            this.menuDoctors.Text = "Lịch trực &Bác sĩ";
            this.menuDepartments.Text = "Danh mục &Khoa/Phòng";

            // Menu Cửa sổ
            this.menuWindow.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.menuCascade,
                this.menuTileHorizontal,
                this.menuTileVertical,
                this.toolStripSeparator2,
                this.menuCloseAll
            });
            this.menuWindow.Text = "&Cửa sổ";

            this.menuCascade.Text = "Xếp &tầng (Cascade)";
            this.menuTileHorizontal.Text = "Sắp xếp &Ngang (Tile Horizontal)";
            this.menuTileVertical.Text = "Sắp xếp &Dọc (Tile Vertical)";
            this.menuCloseAll.Text = "&Đóng tất cả";

            // 
            // StatusStrip
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.lblStatusUser,
                this.pbarStatus,
                this.lblStatusTime
            });
            this.statusStrip1.Location = new System.Drawing.Point(0, 727);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1184, 24);

            this.lblStatusUser.Name = "lblStatusUser";
            this.lblStatusUser.Size = new System.Drawing.Size(260, 19);
            this.lblStatusUser.Text = "Bác sĩ trực: BS. CKII Nguyễn Văn Bình";

            this.pbarStatus.Name = "pbarStatus";
            this.pbarStatus.Size = new System.Drawing.Size(150, 18);
            this.pbarStatus.Value = 100;

            this.lblStatusTime.Name = "lblStatusTime";
            this.lblStatusTime.Size = new System.Drawing.Size(757, 19);
            this.lblStatusTime.Spring = true;
            this.lblStatusTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            // Timer
            this.timerClock.Interval = 1000;

            // 
            // frmHospitalMain
            // 
            this.ClientSize = new System.Drawing.Size(1184, 751);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hệ Thống Quản Lý Bệnh Viện & Truy Xuất Hồ Sơ Bệnh Án (MDI System)";

            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuSystem;
        private System.Windows.Forms.ToolStripMenuItem menuLogout;
        private System.Windows.Forms.ToolStripMenuItem menuReload;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuExit;

        private System.Windows.Forms.ToolStripMenuItem menuManagement;
        private System.Windows.Forms.ToolStripMenuItem menuPatients;
        private System.Windows.Forms.ToolStripMenuItem menuDoctors;
        private System.Windows.Forms.ToolStripMenuItem menuDepartments;

        private System.Windows.Forms.ToolStripMenuItem menuWindow;
        private System.Windows.Forms.ToolStripMenuItem menuCascade;
        private System.Windows.Forms.ToolStripMenuItem menuTileHorizontal;
        private System.Windows.Forms.ToolStripMenuItem menuTileVertical;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem menuCloseAll;

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusUser;
        private System.Windows.Forms.ToolStripProgressBar pbarStatus;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusTime;
        private System.Windows.Forms.Timer timerClock;
    }
}