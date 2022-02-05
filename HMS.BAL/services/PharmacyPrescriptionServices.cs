using HMS.DAL.Repository;
using HMS.Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HMS.BAL.services
{
     public class PharmacyPrescriptionServices
    {

        IPharmacyPrescriptionRepository _pharmacyPrescriptionRepository;
        public PharmacyPrescriptionServices(IPharmacyPrescriptionRepository pharmacyPrescriptionRepository)
        {
            _pharmacyPrescriptionRepository = pharmacyPrescriptionRepository;
        }
        public void AddMedicine(PharmacyPrescription pharmacyPrescription)
        {
            _pharmacyPrescriptionRepository.AddMedicine(pharmacyPrescription);
        }
        public void DeleteMedicine(int PatientId)
        {
            _pharmacyPrescriptionRepository.DeleteMedicine(PatientId);
        }
        public void GetPatientById(int PatientId)
        {
            _pharmacyPrescriptionRepository.GetPatientById(PatientId);
        }
        public void UpdateMedicine(PharmacyPrescription pharmacyPrescription)
        {
            _pharmacyPrescriptionRepository.UpdateMedicine( pharmacyPrescription);
        }
        public void GetMedicines()
        {
            _pharmacyPrescriptionRepository.GetMedicines();
        }

    }
}
