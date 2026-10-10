using ClinicSystem.Core.Entities;
using ClinicSystem.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicSystem.Infrastructure.Repositories
{
    public class DoctorRepository : Repository<Doctor>, IDoctorRepository
    {
        public DoctorRepository(ApplicationDbContext context) : base(context) { }

        public async Task<IEnumerable<Doctor>> GetActiveDoctorsAsync()
        {
            // Translates to SQL: SELECT * FROM Doctors WHERE IsActive = 1
            return await _dbSet.Where(d => d.IsActive).ToListAsync();

        }

        public async Task<IEnumerable<Doctor>> GetDoctorsByDepartmentAsync(int departmentId)
        {
            // Translates to SQL: SELECT * FROM Doctors WHERE DepartmentId = @departmentId
            return await _dbSet.Where(d => d.DepartmentId == departmentId).ToListAsync();
        }
    }
}
