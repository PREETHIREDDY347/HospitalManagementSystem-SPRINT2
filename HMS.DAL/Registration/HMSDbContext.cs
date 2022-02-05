using HMS.Entity.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace HMS.DAL.Registration
{
     public class HMSDbContext:DbContext
    {

        public HMSDbContext(DbContextOptions<HMSDbContext> options) : base(options)
        {

        }

        public DbSet<RegistrationIPD> registrationIPD { get; set; }
        public DbSet<RegistrationOPD> registrationOPD { get; set; }
        public DbSet<PharmacyPrescription> pharmacyPrescription { get; set; }
        public DbSet<PharmacyMedReturn> pharmacyMedReturn { get; set; }
        public DbSet<PharmacyMedIssue> pharmacyMedIssue { get; set; }
        public DbSet<PharmacyBill> pharmacyBill { get; set; }
        public DbSet<PharmacyStock> pharmacyStock { get; set; }
    }
}
