using ClinicSystem.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicSystem.Infrastructure.Repositories
{
    public interface IAppointmentRepository : IRepository<Appointment>
    {
        Task<IEnumerable<Appointment>> GetDoctorAppointmentsAsync(int doctorId, DateTime date);
        Task<bool> HasOverlapAsync(int doctorId, DateTime AppointmentTime, int? excludeAppointmentId = null);

    }
}
