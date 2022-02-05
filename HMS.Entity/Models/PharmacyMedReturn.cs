using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HMS.Entity.Models
{
     public class PharmacyMedReturn
    {
        public PharmacyStock pharmacyStock { get; set; }
        [ForeignKey("pharmacyStock")]
        public string MedName { get; set; }
        public RegistrationOPD registrationOPD { get; set; }
        [ForeignKey("registrationOPD")]
        public int PatientId { get; set; }
        [ForeignKey("registrationOPD")]
        public string PatientName { get; set; }

    }
}
