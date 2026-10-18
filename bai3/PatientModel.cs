using System;

namespace HospitalManagement
{
    public class PatientModel
    {
        public string PatientId { get; set; }
        public string FullName { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Diagnosis { get; set; }
        public string Department { get; set; }
    }
}