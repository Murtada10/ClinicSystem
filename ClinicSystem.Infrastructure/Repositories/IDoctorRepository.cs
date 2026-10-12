using ClinicSystem.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using ClinicSystem.Core.Interfaces;

namespace ClinicSystem.Infrastructure.Repositories
{
    public interface IDoctorRepository : IRepository<Doctor>
    {
        Task<IEnumerable<Doctor>> GetActiveDoctorsAsync();
        Task<IEnumerable<Doctor>> GetDoctorsByDepartmentAsync(int departmentId);

    }
}
