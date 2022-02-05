using HMS.Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HMS.DAL.Repository
{
     public interface IPharmacyPrescriptionRepository
    {
        void AddMedicine(PharmacyPrescription pharmacyPrescription);
        void UpdateMedicine(PharmacyPrescription pharmacyPrescription);
        void DeleteMedicine(int PatientId);
        PharmacyPrescription GetPatientById(int PatientId);
        IEnumerable<PharmacyPrescription> GetMedicines();
    }
}
