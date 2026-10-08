using ClinicSystem.Core.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicSystem.Core.Entities
{
    public class DoctorShift : AuditableEntity
    {
        // Foreign Key
        public int DoctorId { get; set; }

        // Navigation Property
        public Doctor Doctor { get; set; } = null!;

        public DateTime ShiftDate { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }

    }
}
