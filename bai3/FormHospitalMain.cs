using System;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace HospitalManagement
{
    public partial class formHospitalMain : Form
    {
        public formHospitalMain()
        {
            InitializeComponent();
            RegisterEvents();

            timerClock.Start();
        }

        private void RegisterEvents()
        {
            // Cập nhật đồng hồ thời gian
            timerClock.Tick += (s, e) => lblStatusTime.Text = $"Thời gian hệ thống: {DateTime.Now:dd/MM/yyyy HH:mm:ss}";

            // Menu Hệ thống
            menuLogout.Click += (s, e) => MessageBox.Show("Đã đăng xuất khỏi hệ thống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            menuReload.Click += (s, e) => SimulateReloadData();
            menuExit.Click += (s, e) => Application.Exit();

            // Menu Quản lý mở các Form Con
            menuPatients.Click += (s, e) => OpenChildForm<formPatientProfiles>();
            menuDoctors.Click += (s, e) => OpenChildForm<formDoctorSchedule>();
            menuDepartments.Click += (s, e) => MessageBox.Show("Chức năng Danh mục Khoa/Phòng đang phát triển.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Menu Điều hướng cửa sổ MDI
            menuCascade.Click += (s, e) => this.LayoutMdi(MdiLayout.Cascade);
            menuTileHorizontal.Click += (s, e) => this.LayoutMdi(MdiLayout.TileHorizontal);
            menuTileVertical.Click += (s, e) => this.LayoutMdi(MdiLayout.TileVertical);
            menuCloseAll.Click += (s, e) => CloseAllChildForms();
        }

        // ================= YÊU CẦU NGHIỆP VỤ 1: QUẢN LÝ VÒNG ĐỜI FORM CON =================
        /// <summary>
        /// Mở một Form con MDI. Nếu Form đã tồn tại thì Activate(), nếu chưa thì khởi tạo mới.
        /// </summary>
        private void OpenChildForm<T>() where T : Form, new()
        {
            // Duyệt qua danh sách các Form con đang mở trên Form Cha MDI
            foreach (Form child in this.MdiChildren)
            {
                if (child is T)
                {
                    // Nếu đã tồn tại Form con cùng kiểu, mang Form đó lên trên cùng và kích hoạt
                    child.Activate();
                    if (child.WindowState == FormWindowState.Minimized)
                    {
                        child.WindowState = FormWindowState.Normal;
                    }
                    return;
                }
            }

            // Nếu chưa mở, tạo mới Instance, gán MdiParent và gọi Show()
            T newChild = new T
            {
                MdiParent = this
            };
            newChild.Show();
        }

        private void CloseAllChildForms()
        {
            foreach (Form child in this.MdiChildren)
            {
                child.Close();
            }
        }

        private void SimulateReloadData()
        {
            pbarStatus.Value = 0;
            System.Windows.Forms.Timer t = new Timer { Interval = 50 };
            t.Tick += (s, e) =>
            {
                if (pbarStatus.Value < 100)
                {
                    pbarStatus.Value += 10;
                }
                else
                {
                    t.Stop();
                    t.Dispose();
                    MessageBox.Show("Nạp lại dữ liệu toàn hệ thống thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            };
            t.Start();
        }
    }
}