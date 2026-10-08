using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicSystem.Core
{
    public class Appointment : AuditableEntity
    {
        // Foreign Keys
        public int PatientId { get; set; }
        public int DoctorId { get; set; }

        // Navigation Properties (Tells EF Core how tables connect)
        public Patient Patient { get; set; }
        public Doctor Doctor { get; set; }

        public DateTime AppointmentDate { get; set; }
        public string Reason { get; set; } = string.Empty;
        public string Status { get; set; } = "Scheduled";
    }
}
