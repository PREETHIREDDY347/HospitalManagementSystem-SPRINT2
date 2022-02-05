using System;
using System.Collections.Generic;
using System.Text;

namespace HMS.Entity.Models
{
     public class AdminEmployee
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }

        public string EmployeeRole { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
        public string ReEnterPassword { get; set; }
    }
}

