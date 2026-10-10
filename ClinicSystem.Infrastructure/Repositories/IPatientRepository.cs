using ClinicSystem.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicSystem.Infrastructure.Repositories
{
    public interface IPatientRepository : IRepository<Patient>
    {
        // Custom query to look up a patient by contact number        
        Task<Patient?> GetByPhoneAsync(string phone);
        
    }
}
