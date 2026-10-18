using System.ComponentModel;
using System.Windows.Forms;

namespace HospitalManagement
{
    public partial class formDoctorSchedule : Form
    {
        private BindingList<DoctorModel> doctorList;

        public formDoctorSchedule()
        {
            InitializeComponent();
            SetupDataGridView();
            LoadSampleData();
        }

        private void SetupDataGridView()
        {
            dgvDoctors.AutoGenerateColumns = false;
            dgvDoctors.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDoctors.ReadOnly = true;
            dgvDoctors.AllowUserToAddRows = false;

            dgvDoctors.Columns.Clear();
            dgvDoctors.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "DoctorId", HeaderText = "Mã BS", Width = 90 });
            dgvDoctors.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "DoctorName", HeaderText = "Tên Bác sĩ", Width = 200 });
            dgvDoctors.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Specialty", HeaderText = "Chuyên khoa", Width = 160 });
            dgvDoctors.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Shift", HeaderText = "Ca trực", Width = 140 });
            dgvDoctors.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Room", HeaderText = "Phòng trực", Width = 120 });
        }

        private void LoadSampleData()
        {
            doctorList = new BindingList<DoctorModel>
            {
                new DoctorModel { DoctorId = "BS01", DoctorName = "BS. CKII Nguyễn Văn Bình", Specialty = "Cấp cứu", Shift = "Ca sáng (07:00 - 15:00)", Room = "P.101" },
                new DoctorModel { DoctorId = "BS02", DoctorName = "ThS.BS Phùng Thị Hoa", Specialty = "Nội tổng hợp", Shift = "Ca chiều (15:00 - 23:00)", Room = "P.205" },
                new DoctorModel { DoctorId = "BS03", DoctorName = "BS. CKI Phạm Quốc Huy", Specialty = "Ngoại thần kinh", Shift = "Ca đêm (23:00 - 07:00)", Room = "P.302" }
            };

            dgvDoctors.DataSource = doctorList;
        }
    }
}