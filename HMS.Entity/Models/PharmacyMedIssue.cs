using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HMS.Entity.Models
{
     public class PharmacyMedIssue
    {
       [Key]
        public string MedCause { get; set; }
    }
}
