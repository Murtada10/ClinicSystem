using ClinicSystem.Core.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicSystem.Core.Entities
{
    public class MedicalRecord : AuditableEntity
    {
        // Foreign Key
        public int PatientId { get; set; }

        // Navigation Property
        public Patient Patient { get; set; } = null!;

        public string Diagnosis { get; set; } = string.Empty;
        public string Treatment { get; set; } = string.Empty;
        public string Notes { get; set; } = string.Empty;
        public DateTime RecordDate { get; set; } = DateTime.UtcNow;


    }
}
