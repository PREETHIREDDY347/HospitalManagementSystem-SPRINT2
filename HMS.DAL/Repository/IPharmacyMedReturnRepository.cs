using HMS.Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HMS.DAL.Repository
{
     public interface IPharmacyMedReturnRepository
    {

        void AddMedicine(PharmacyMedReturn pharmacyMedReturn);
        void UpdateMedicine(PharmacyMedReturn pharmacyMedReturn);
        void DeleteMedicine(int PatientId);
        PharmacyMedReturn GetPatientById(int PatientId);
        IEnumerable<PharmacyMedReturn> GetMedicines();
    }
}
