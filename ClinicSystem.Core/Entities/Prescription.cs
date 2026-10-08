using ClinicSystem.Core.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicSystem.Core.Entities
{
    public class Prescription : AuditableEntity
    {
        // Foreign Keys
        public int PatientId { get; set; }
        public int MedicationId { get; set; }

        // Navigation Properties
        public Patient patient { get; set; } = null!;
        public Medication Medication { get; set; } = null!;

        public string DosageInstructions { get; set; } = string.Empty;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

    }
}
