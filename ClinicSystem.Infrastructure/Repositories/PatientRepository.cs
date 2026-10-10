using ClinicSystem.Core.Entities;
using ClinicSystem.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicSystem.Infrastructure.Repositories
{
    public class PatientRepository : Repository<Patient> , IPatientRepository
    {
        public PatientRepository(ApplicationDbContext context) : base(context)
        {

        }
        public async Task<Patient?> GetByPhoneAsync(string phone)
        {
            // Translates to SQL: SELECT TOP(1) * FROM Patients WHERE Phone = @phone
            return await _dbSet.FirstOrDefaultAsync(p => p.Phone == phone);
        }
    }
}
