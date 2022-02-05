using HMS.DAL.Repository;
using HMS.Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HMS.BAL.services
{
     public class PharmacyMedReturnServices
    {
        IPharmacyMedReturnRepository _pharmacyMedReturnRepository;
        public PharmacyMedReturnServices(IPharmacyMedReturnRepository pharmacyMedReturnRepository)
        {
            _pharmacyMedReturnRepository = pharmacyMedReturnRepository;
        }
        public void AddMedicine(PharmacyMedReturn pharmacyMedReturn)
        {
            _pharmacyMedReturnRepository.AddMedicine(pharmacyMedReturn);
        }
        
        public void GetPatientById(int PatientId)
        {
            _pharmacyMedReturnRepository.GetPatientById(PatientId);
        }
        public void DeleteMedicine(int PatientId)
        {
            _pharmacyMedReturnRepository.DeleteMedicine(PatientId);
        }
        public void UpdateMedicine(PharmacyMedReturn pharmacyMedReturn)
        {
            _pharmacyMedReturnRepository.UpdateMedicine(pharmacyMedReturn);
        }
        public void GetMedicines()
        {
            _pharmacyMedReturnRepository.GetMedicines();
        }

    }
}
