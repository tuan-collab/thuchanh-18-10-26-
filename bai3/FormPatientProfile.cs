using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Xml.Linq;

namespace HospitalManagement
{
    public partial class formPatientProfiles : Form
    {
        private BindingList<PatientModel> patientList;
        private BindingSource bindingSource;

        public formPatientProfiles()
        {
            InitializeComponent();
            SetupDataGridView();
            SetupDataBinding();
            LoadSampleData();
        }

        private void SetupDataGridView()
        {
            dgvPatients.AutoGenerateColumns = false;
            dgvPatients.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPatients.ReadOnly = true;
            dgvPatients.AllowUserToAddRows = false;

            dgvPatients.Columns.Clear();
            dgvPatients.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "PatientId", HeaderText = "Mã BN", Width = 80 });
            dgvPatients.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "FullName", HeaderText = "Họ và tên", Width = 160 });
            dgvPatients.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Age", HeaderText = "Tuổi", Width = 60 });
            dgvPatients.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Gender", HeaderText = "Giới tính", Width = 80 });
            dgvPatients.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Department", HeaderText = "Khoa điều trị", Width = 140 });
            dgvPatients.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Diagnosis", HeaderText = "Chẩn đoán", Width = 220 });
        }

        private void SetupDataBinding()
        {
            patientList = new BindingList<PatientModel>();
            bindingSource = new BindingSource { DataSource = patientList };
            dgvPatients.DataSource = bindingSource;

            txtId.DataBindings.Add("Text", bindingSource, "PatientId", true, DataSourceUpdateMode.OnPropertyChanged);
            txtName.DataBindings.Add("Text", bindingSource, "FullName", true, DataSourceUpdateMode.OnPropertyChanged);
            txtAge.DataBindings.Add("Text", bindingSource, "Age", true, DataSourceUpdateMode.OnPropertyChanged);
            cboGender.DataBindings.Add("Text", bindingSource, "Gender", true, DataSourceUpdateMode.OnPropertyChanged);
            cboDept.DataBindings.Add("Text", bindingSource, "Department", true, DataSourceUpdateMode.OnPropertyChanged);
            txtDiagnosis.DataBindings.Add("Text", bindingSource, "Diagnosis", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void LoadSampleData()
        {
            patientList.Add(new PatientModel { PatientId = "BN001", FullName = "Trần Văn Hùng", Age = 45, Gender = "Nam", Department = "Khoa Tim mạch", Diagnosis = "Tăng huyết áp độ 2" });
            patientList.Add(new PatientModel { PatientId = "BN002", FullName = "Lê Thị Mai", Age = 32, Gender = "Nữ", Department = "Khoa Nội", Diagnosis = "Viêm dạ dày cấp" });
        }
    }
}