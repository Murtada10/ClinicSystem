using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicSystem.Core
{
    public class Department : AuditableEntity
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

        // Navigation Property: One Department has many Doctors
        public ICollection<Doctor> Doctors { get; set; } = new List<Doctor>();

    }
}
