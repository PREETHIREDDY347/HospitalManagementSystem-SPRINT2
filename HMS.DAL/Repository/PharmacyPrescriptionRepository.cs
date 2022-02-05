using HMS.DAL.Registration;
using HMS.Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace HMS.DAL.Repository
{
    public class PharmacyPrescriptionRepository : IPharmacyPrescriptionRepository
    {
        HMSDbContext _hMSDbContext;
        public PharmacyPrescriptionRepository(HMSDbContext hMSDbContext)
        {
            _hMSDbContext = hMSDbContext;
        }
        public void AddMedicine(PharmacyPrescription pharmacyPrescription)
        {
            _hMSDbContext.pharmacyPrescription.Add(pharmacyPrescription);
            _hMSDbContext.SaveChanges();
        }

        public void DeleteMedicine(int PatientId)
        {
            var pharmacyPrescription = _hMSDbContext.pharmacyPrescription.Find(PatientId);
            _hMSDbContext.pharmacyPrescription.Remove(pharmacyPrescription);
            _hMSDbContext.SaveChanges();
        }

        public PharmacyPrescription GetPatientById(int PatientId)
        {
            return _hMSDbContext.pharmacyPrescription.Find(PatientId);
        }

        public IEnumerable<PharmacyPrescription> GetMedicines()
        {
            return _hMSDbContext.pharmacyPrescription.ToList();
        }

        public void UpdateMedicine(PharmacyPrescription pharmacyPrescription)
        {
            _hMSDbContext.Entry(pharmacyPrescription).State = EntityState.Modified;
            _hMSDbContext.SaveChanges();


        }
    }
}
