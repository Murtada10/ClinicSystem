using System.Collections.Generic;
using System.Threading.Tasks;
using ClinicSystem.Core.Entities;

namespace ClinicSystem.Core.Interfaces
{
    public interface IPatientService
    {
        Task<IEnumerable<Patient>> GetAllPatientsAsync();
        Task<bool> RegisterNewPatientAsync(Patient patient);
    }

}
