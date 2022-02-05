using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HMS.Entity.Models
{
     public class PharmacyBill
    {
        public PharmacyStock pharmacyStock { get; set; }
        [ForeignKey("pharmacyStock")]


        public string MedName { get; set; }
        [ForeignKey("pharmacyStock")]


        public string MedAmount { get; set; }

    }
}
