namespace BookManagement
{
    partial class formBookManager
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

            // System Bars
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOpenCsv = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSaveCsv = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSearch = new System.Windows.Forms.ToolStripMenuItem();

            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnToolOpen = new System.Windows.Forms.ToolStripButton();
            this.btnToolSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnToolAdd = new System.Windows.Forms.ToolStripButton();

            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatusTotalBooks = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblStatusTotalValue = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblStatusTime = new System.Windows.Forms.ToolStripStatusLabel();

            // Controls
            this.gbDetail = new System.Windows.Forms.GroupBox();
            this.lblBookId = new System.Windows.Forms.Label();
            this.txtBookId = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblCoverPath = new System.Windows.Forms.Label();
            this.txtCoverPath = new System.Windows.Forms.TextBox();

            this.picBookCover = new System.Windows.Forms.PictureBox();
            this.btnBrowseCover = new System.Windows.Forms.Button();

            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();

            this.gbSearch = new System.Windows.Forms.GroupBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();

            this.dgvBooks = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.timerClock = new System.Windows.Forms.Timer(this.components);

            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.gbDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBookCover)).BeginInit();
            this.pnlButtons.SuspendLayout();
            this.gbSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();

            // 
            // MenuStrip
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.menuFile,
                this.menuEdit
            });
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 24);

            // menuFile
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.menuOpenCsv,
                this.menuSaveCsv,
                this.toolStripSeparator1,
                this.menuExit
            });
            this.menuFile.Text = "&File";

            this.menuOpenCsv.Text = "&Mở file CSV";
            this.menuSaveCsv.Text = "&Lưu file CSV";
            this.menuExit.Text = "T&hoát";

            // menuEdit
            this.menuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.menuAdd,
                this.menuDelete,
                this.menuSearch
            });
            this.menuEdit.Text = "&Edit";

            this.menuAdd.Text = "&Thêm sách";
            this.menuDelete.Text = "&Xóa sách";
            this.menuSearch.Text = "T&ìm kiếm";

            // 
            // ToolStrip
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.btnToolOpen,
                this.btnToolSave,
                this.toolStripSeparator2,
                this.btnToolAdd
            });
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(984, 25);

            this.btnToolOpen.Text = "📁 Mở CSV";
            this.btnToolSave.Text = "💾 Lưu CSV";
            this.btnToolAdd.Text = "➕ Thêm mới";

            // 
            // StatusStrip
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.lblStatusTotalBooks,
                this.lblStatusTotalValue,
                this.lblStatusTime
            });
            this.statusStrip1.Location = new System.Drawing.Point(0, 637);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(984, 22);

            this.lblStatusTotalBooks.Name = "lblStatusTotalBooks";
            this.lblStatusTotalBooks.Size = new System.Drawing.Size(250, 17);
            this.lblStatusTotalBooks.Text = "Tổng số đầu sách: 0";

            this.lblStatusTotalValue.Name = "lblStatusTotalValue";
            this.lblStatusTotalValue.Size = new System.Drawing.Size(350, 17);
            this.lblStatusTotalValue.Text = "Tổng giá trị kho: 0 VNĐ";

            this.lblStatusTime.Name = "lblStatusTime";
            this.lblStatusTime.Size = new System.Drawing.Size(300, 17);
            this.lblStatusTime.Spring = true;
            this.lblStatusTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            // 
            // GroupBox Detail (Chi tiết sách)
            // 
            this.gbDetail.Controls.Add(this.lblBookId);
            this.gbDetail.Controls.Add(this.txtBookId);
            this.gbDetail.Controls.Add(this.lblTitle);
            this.gbDetail.Controls.Add(this.txtTitle);
            this.gbDetail.Controls.Add(this.lblAuthor);
            this.gbDetail.Controls.Add(this.txtAuthor);
            this.gbDetail.Controls.Add(this.lblCategory);
            this.gbDetail.Controls.Add(this.cboCategory);
            this.gbDetail.Controls.Add(this.lblPrice);
            this.gbDetail.Controls.Add(this.txtPrice);
            this.gbDetail.Controls.Add(this.lblQuantity);
            this.gbDetail.Controls.Add(this.txtQuantity);
            this.gbDetail.Controls.Add(this.lblCoverPath);
            this.gbDetail.Controls.Add(this.txtCoverPath);
            this.gbDetail.Controls.Add(this.picBookCover);
            this.gbDetail.Controls.Add(this.btnBrowseCover);
            this.gbDetail.Location = new System.Drawing.Point(12, 55);
            this.gbDetail.Size = new System.Drawing.Size(960, 185);
            this.gbDetail.Text = "Chi tiết thông tin sách";

            // Controls inside gbDetail
            this.lblBookId.Text = "Mã sách:";
            this.lblBookId.Location = new System.Drawing.Point(15, 30);
            this.lblBookId.AutoSize = true;
            this.txtBookId.Location = new System.Drawing.Point(95, 27);
            this.txtBookId.Size = new System.Drawing.Size(150, 22);
            this.txtBookId.ReadOnly = true;

            this.lblTitle.Text = "Tên sách:";
            this.lblTitle.Location = new System.Drawing.Point(265, 30);
            this.lblTitle.AutoSize = true;
            this.txtTitle.Location = new System.Drawing.Point(340, 27);
            this.txtTitle.Size = new System.Drawing.Size(210, 22);

            this.lblAuthor.Text = "Tác giả:";
            this.lblAuthor.Location = new System.Drawing.Point(570, 30);
            this.lblAuthor.AutoSize = true;
            this.txtAuthor.Location = new System.Drawing.Point(635, 27);
            this.txtAuthor.Size = new System.Drawing.Size(160, 22);

            this.lblCategory.Text = "Thể loại:";
            this.lblCategory.Location = new System.Drawing.Point(15, 70);
            this.lblCategory.AutoSize = true;
            this.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategory.Items.AddRange(new object[] { "Văn học", "Kinh tế", "Công nghệ thông tin", "Kỹ năng sống", "Ngoại ngữ", "Thiếu nhi" });
            this.cboCategory.Location = new System.Drawing.Point(95, 67);
            this.cboCategory.Size = new System.Drawing.Size(150, 24);

            this.lblPrice.Text = "Đơn giá:";
            this.lblPrice.Location = new System.Drawing.Point(265, 70);
            this.lblPrice.AutoSize = true;
            this.txtPrice.Location = new System.Drawing.Point(340, 67);
            this.txtPrice.Size = new System.Drawing.Size(210, 22);

            this.lblQuantity.Text = "Số lượng:";
            this.lblQuantity.Location = new System.Drawing.Point(570, 70);
            this.lblQuantity.AutoSize = true;
            this.txtQuantity.Location = new System.Drawing.Point(635, 67);
            this.txtQuantity.Size = new System.Drawing.Size(160, 22);

            this.lblCoverPath.Text = "Đường dẫn:";
            this.lblCoverPath.Location = new System.Drawing.Point(15, 110);
            this.lblCoverPath.AutoSize = true;
            this.txtCoverPath.Location = new System.Drawing.Point(95, 107);
            this.txtCoverPath.Size = new System.Drawing.Size(580, 22);
            this.txtCoverPath.ReadOnly = true;

            this.btnBrowseCover.Text = "Tải ảnh bìa";
            this.btnBrowseCover.Location = new System.Drawing.Point(685, 105);
            this.btnBrowseCover.Size = new System.Drawing.Size(110, 26);

            // PictureBox
            this.picBookCover.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBookCover.Location = new System.Drawing.Point(815, 20);
            this.picBookCover.Size = new System.Drawing.Size(130, 150);
            this.picBookCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;

            // 
            // Panel Buttons
            // 
            this.pnlButtons.Controls.Add(this.btnAdd);
            this.pnlButtons.Controls.Add(this.btnEdit);
            this.pnlButtons.Controls.Add(this.btnDelete);
            this.pnlButtons.Controls.Add(this.btnReset);
            this.pnlButtons.Location = new System.Drawing.Point(12, 245);
            this.pnlButtons.Size = new System.Drawing.Size(530, 45);

            this.btnAdd.Text = "Thêm mới";
            this.btnAdd.Location = new System.Drawing.Point(10, 5);
            this.btnAdd.Size = new System.Drawing.Size(110, 35);

            this.btnEdit.Text = "Sửa thông tin";
            this.btnEdit.Location = new System.Drawing.Point(140, 5);
            this.btnEdit.Size = new System.Drawing.Size(110, 35);

            this.btnDelete.Text = "Xóa sách";
            this.btnDelete.Location = new System.Drawing.Point(270, 5);
            this.btnDelete.Size = new System.Drawing.Size(110, 35);

            this.btnReset.Text = "Làm mới";
            this.btnReset.Location = new System.Drawing.Point(400, 5);
            this.btnReset.Size = new System.Drawing.Size(110, 35);

            // 
            // GroupBox Search
            // 
            this.gbSearch.Controls.Add(this.lblSearch);
            this.gbSearch.Controls.Add(this.txtSearch);
            this.gbSearch.Controls.Add(this.btnSearch);
            this.gbSearch.Location = new System.Drawing.Point(550, 240);
            this.gbSearch.Size = new System.Drawing.Size(422, 50);
            this.gbSearch.Text = "Tìm kiếm";

            this.lblSearch.Text = "Từ khóa:";
            this.lblSearch.Location = new System.Drawing.Point(10, 20);
            this.lblSearch.AutoSize = true;

            this.txtSearch.Location = new System.Drawing.Point(75, 17);
            this.txtSearch.Size = new System.Drawing.Size(220, 22);

            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.Location = new System.Drawing.Point(305, 15);
            this.btnSearch.Size = new System.Drawing.Size(100, 26);

            // 
            // DataGridView dgvBooks
            // 
            this.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooks.Location = new System.Drawing.Point(12, 300);
            this.dgvBooks.Size = new System.Drawing.Size(960, 325);

            // 
            // ErrorProvider & Timer
            // 
            this.errorProvider1.ContainerControl = this;
            this.timerClock.Interval = 1000;

            // 
            // frmBookManager Form Setup
            // 
            this.ClientSize = new System.Drawing.Size(984, 659);
            this.Controls.Add(this.dgvBooks);
            this.Controls.Add(this.gbSearch);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.gbDetail);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hệ Thống Quản Lý Tài Liệu Sách & Xuất Báo Cáo Nhà Sách";

            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.gbDetail.ResumeLayout(false);
            this.gbDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBookCover)).EndInit();
            this.pnlButtons.ResumeLayout(false);
            this.gbSearch.ResumeLayout(false);
            this.gbSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuOpenCsv;
        private System.Windows.Forms.ToolStripMenuItem menuSaveCsv;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private System.Windows.Forms.ToolStripMenuItem menuEdit;
        private System.Windows.Forms.ToolStripMenuItem menuAdd;
        private System.Windows.Forms.ToolStripMenuItem menuDelete;
        private System.Windows.Forms.ToolStripMenuItem menuSearch;

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnToolOpen;
        private System.Windows.Forms.ToolStripButton btnToolSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnToolAdd;

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusTotalBooks;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusTotalValue;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusTime;

        private System.Windows.Forms.GroupBox gbDetail;
        private System.Windows.Forms.Label lblBookId;
        private System.Windows.Forms.TextBox txtBookId;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblCoverPath;
        private System.Windows.Forms.TextBox txtCoverPath;
        private System.Windows.Forms.PictureBox picBookCover;
        private System.Windows.Forms.Button btnBrowseCover;

        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnReset;

        private System.Windows.Forms.GroupBox gbSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;

        private System.Windows.Forms.DataGridView dgvBooks;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Timer timerClock;
    }
}