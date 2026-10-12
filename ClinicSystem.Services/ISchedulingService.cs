using System.Collections.Generic;
using System.Threading.Tasks;
using ClinicSystem.Core.Entities;

namespace ClinicSystem.Services
{
    public interface ISchedulingService
    {
        Task<bool> BookAppointmentAsync(Appointment appointment);
        Task<IEnumerable<Appointment>> GetAllAppointmentsAsync();
    }
}
