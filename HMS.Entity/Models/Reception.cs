using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HMS.Entity.Models
{
    public  class Reception
    {
        public RegistrationOPD registrationOPD { get; set; }
        [ForeignKey("registrationOPD")]

        public int PatientId { get; set; }
        [ForeignKey("registrationOPD")]
        public string PatientName { get; set; }
        [ForeignKey("registrationOPD")]
        public string PatientIssue { get; set; }


        public AdminDoctor adminDoctor { get; set; }
        [ForeignKey("adminDoctor")]
        public string DoctorName { get; set; }
        [ForeignKey("adminDoctor")]
        public string DoctorSpecialization { get; set; }
        public string ReferralDoctor { get; set; }

        public TimeSpan DoctorAvailabilty { get; set; }


    }
}
