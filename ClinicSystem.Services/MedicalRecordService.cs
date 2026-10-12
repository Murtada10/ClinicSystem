using ClinicSystem.Core.Entities;
using ClinicSystem.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicSystem.Services
{
    public class MedicalRecordService : IMedicalRecordService
    {
        private readonly IRepository<MedicalRecord> _recordRepository;

        // Constructor Injection
        public MedicalRecordService(IRepository<MedicalRecord> recordRepository)
        {
            _recordRepository = recordRepository;
        }

        public async Task<IEnumerable<MedicalRecord>> GetPatientRecordsAsync(int patientId, int requestingDoctorId)
        {
            // Business Logic: Strict authorization logging (Simulated Security Check)
            Console.WriteLine($"\n[SECURITY LOG] Verifying Doctor ID {requestingDoctorId}'s access to Patient ID {patientId}'s records...");
            await Task.Delay(300); // Simulate security validation delay

            var allRecords = await _recordRepository.GetAllAsync();

            // Filter to return ONLY the requested patient's records
            return allRecords.Where(r => r.PatientId == patientId);
        }

        public async Task<bool> AddSecureRecordAsync(MedicalRecord record, int requestingDoctorId)
        {
            // 1. Business Logic: Validation
            if (string.IsNullOrWhiteSpace(record.Diagnosis))
            {
                Console.WriteLine("\n[ERROR] Business Rule Violation: Medical record must contain a valid diagnosis.");
                return false;
            }

            // 2. Business Logic: Strict Authorization Check
            if (record.DoctorId != requestingDoctorId)
            {
                Console.WriteLine("\n[SECURITY VIOLATION] Doctor ID mismatch. You cannot add records under another doctor's ID.");
                return false; // Reject the save
            }

            // 3. Save to database if all security checks pass
            await _recordRepository.AddAsync(record);
            Console.WriteLine($"\n[SUCCESS] Secure medical record added to Patient ID {record.PatientId}.");
            return true;
        }
    }
}