using ClinicSystem.Core.Entities;
using ClinicSystem.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ClinicSystem.Services
{
    public interface IDoctorService
    {
        Task<IEnumerable<Doctor>> GetAllDoctorsAsync();
        Task<bool> RegisterDoctorAsync(Doctor doctor);
    }
}
