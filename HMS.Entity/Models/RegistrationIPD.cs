using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HMS.Entity.Models
{
     public class RegistrationIPD
    {
        [Key]
        public int PatientId { get; set; }
        public string PatientName { get; set; }
        public int AdmissionDate { get; set; }
        public int Age { get; set; }
        public int Gender { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string BloodGroup { get; set; }
        public string PatientIssue { get; set; }
        public string DoctorName { get; set; }
        public string DoctorType { get; set; }
        public int WardNumber { get; set; }
        public int BedNumber { get; set; }

    }
}
