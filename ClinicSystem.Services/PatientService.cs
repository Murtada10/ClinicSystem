using ClinicSystem.Core.Entities;
using ClinicSystem.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicSystem.Services
{
    public class PatientService : IPatientService
    {
        private readonly IRepository<Patient> _patientRepository;

        // Constructor Injection
        public PatientService(IRepository<Patient> patientRepository)
        {
            _patientRepository = patientRepository;
        }

        public async Task<IEnumerable<Patient>> GetAllPatientsAsync()
        {
            return await _patientRepository.GetAllAsync();
        }

        public async Task<bool> RegisterNewPatientAsync(Patient patient)
        {
            // 1. Business Logic: Onboarding Validation
            if (string.IsNullOrWhiteSpace(patient.FullName))
            {
                Console.WriteLine("\n[ERROR] Business Rule Violation: Patient name cannot be empty.");
                return false;
            }

            // 2. Business Logic: Duplicate Check
            var existingPatients = await _patientRepository.GetAllAsync();
            bool isDuplicate = existingPatients.Any(p => p.FullName.Equals(patient.FullName, StringComparison.OrdinalIgnoreCase));

            if (isDuplicate)
            {
                // FIXED: Changed patient.Name to patient.FullName here!
                Console.WriteLine($"\n[WARNING] Duplicate check failed: A patient named '{patient.FullName}' is already registered.");
                return false; // Reject the save
            }

            // 3. If validation passes, save to the infrastructure layer
            await _patientRepository.AddAsync(patient);
            return true;
        }
    }
}