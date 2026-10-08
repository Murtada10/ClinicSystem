using ClinicSystem.Core.Common;
using ClinicSystem.Core.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicSystem.Core.Entities
{
    public class Appointment : AuditableEntity
    {
        // Foreign Keys
        public int PatientId { get; set; }
        public int DoctorId { get; set; }

        // Navigation Properties (Tells EF Core how tables connect)
        public Patient Patient { get; set; } = null!;
        public Doctor Doctor { get; set; } = null!;

        public DateTime AppointmentDate { get; set; }
        public string Reason { get; set; } = string.Empty;

        public AppointmentStatus Status { get; set; } = AppointmentStatus.Scheduled;

    }
}
