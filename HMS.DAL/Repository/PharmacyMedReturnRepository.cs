using HMS.DAL.Registration;
using HMS.Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace HMS.DAL.Repository
{
    public  class PharmacyMedReturnRepository: IPharmacyMedReturnRepository
    {

        HMSDbContext _hMSDbContext;
        public PharmacyMedReturnRepository(HMSDbContext hMSDbContext)
        {
            _hMSDbContext = hMSDbContext;
        }
        public void AddMedicine(PharmacyMedReturn pharmacyMedReturn)
        {
            _hMSDbContext.pharmacyMedReturn.Add(pharmacyMedReturn);
            _hMSDbContext.SaveChanges();
        }

        
        public PharmacyMedReturn GetPatientById(int PatientId)
        {
            return _hMSDbContext.pharmacyMedReturn.Find(PatientId);
        }

        public void DeleteMedicine(int PatientId)
        {
            var pharmacyMedReturn = _hMSDbContext.pharmacyMedReturn.Find(PatientId);
            _hMSDbContext.pharmacyMedReturn.Remove(pharmacyMedReturn);
            _hMSDbContext.SaveChanges();
        }

        public IEnumerable<PharmacyMedReturn> GetMedicines()
        {
            return _hMSDbContext.pharmacyMedReturn.ToList();
        }

        public void UpdateMedicine(PharmacyMedReturn pharmacyMedReturn)
        {
            _hMSDbContext.Entry(pharmacyMedReturn).State = EntityState.Modified;
            _hMSDbContext.SaveChanges();


        }
    }

}
