using ClinicSystem.Core.Entities;
using ClinicSystem.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicSystem.Services
{
    public class DoctorService : IDoctorService
    {
        private readonly IRepository<Doctor> _doctorRepository;

        // Constructor Injection locking in the Repository pattern
        public DoctorService(IRepository<Doctor> doctorRepository)
        {
            _doctorRepository = doctorRepository;
        }

        public async Task<IEnumerable<Doctor>> GetAllDoctorsAsync()
        {
            return await _doctorRepository.GetAllAsync();
        }

        public async Task<bool> RegisterDoctorAsync(Doctor doctor)
        {
            // Business Logic: Validation
            if(string.IsNullOrWhiteSpace(doctor.FullName))
            {
                Console.WriteLine("\n[ERROR] Business Rule Violation: Doctor name cannot be empty.");
                return false;
            }
            if(string.IsNullOrEmpty(doctor.Specialization))
            {
                Console.WriteLine("\n[ERROR] Business Rule Violation: Doctor must have a designated specialization.");
                return false;
            }

            // Save to the database via Layer 1 abstractions
            await _doctorRepository.AddAsync(doctor);
            Console.WriteLine($"\n[SUCCESS] Dr. {doctor.FullName} ({doctor.Specialization}) has been added to the clinic roster.");
            return true;

        }
        

    }
}
