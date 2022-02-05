using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HMS.Entity.Models
{
     public class PharmacyStock
    {
        [Key]
        public string MedName { get; set; }
        
        public PharmacyMedIssue pharmacyMedIssue { get; set; }
        [ForeignKey("pharmacyMedIssue")]

        public string MedCause { get; set; }
        public string MedAmount { get; set; }
        public bool AvailableStock { get; set; }
    }
}
