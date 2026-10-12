using ClinicSystem.Core.Entities;
using ClinicSystem.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ClinicSystem.Core.Interfaces;

namespace ClinicSystem.Services
{
    public class SchedulingService : ISchedulingService
    {
        private readonly IRepository<Appointment> _appointmentRepository;

        // Constructor Injection: We inject the Repository so the Service can talk to the database
        public SchedulingService(IRepository<Appointment> appointmentRepository)
        {
            _appointmentRepository = appointmentRepository;
        }

        public async Task<bool> BookAppointmentAsync(Appointment appointment)
        {
            // 1. Fetch all existing appointments to check for conflicts
            var existingAppointment = await _appointmentRepository.GetAllAsync();

            // 2. Business Logic: Anti-double-booking rule
            bool isDoubleBooked = existingAppointment.Any(a =>
            a.DoctorId == appointment.DoctorId &&
            a.AppointmentDate == appointment.AppointmentDate);

            if(isDoubleBooked)
            {
                Console.WriteLine("\n[WARNING] Business Rule Violation: The doctor is already booked at this exact date and time.");
                return false; // Reject the save
             }
            // 3. If no conflict, save to the database
            await _appointmentRepository.AddAsync(appointment);
            return true;


        }
        public async Task<IEnumerable<Appointment>> GetAllAppointmentsAsync()
        {
            return await _appointmentRepository.GetAllAsync();
        }

    }
}
