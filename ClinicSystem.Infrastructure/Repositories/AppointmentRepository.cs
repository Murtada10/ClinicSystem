using ClinicSystem.Core.Entities;
using ClinicSystem.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicSystem.Infrastructure.Repositories
{
    public class AppointmentRepository : Repository<Appointment>, IAppointmentRepository
    {
        public AppointmentRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Appointment>> GetDoctorAppointmentsAsync(int doctorId, DateTime date)
        {
            // Retrieves all scheduled consultations for a doctor on a specific day
            return await _dbSet
                .Where(a => a.DoctorId == doctorId && a.AppointmentDate.Date == date.Date)
                .ToListAsync();
        }

        public async Task<bool> HasOverlapAsync(int doctorId, DateTime appointmentTime, int? excludeAppointmentId = null)
        {
            // Checks whether an active slot collision exists for the selected doctor
            return await _dbSet.AnyAsync(a =>
                a.DoctorId == doctorId &&
                a.AppointmentDate == appointmentTime &&
                (!excludeAppointmentId.HasValue || a.Id != excludeAppointmentId.Value));
        }
    }
}