using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicSystem.Core
{
    public class Invoice : AuditableEntity
    {
        // Foreign Key
        public int PatientId { get; set; }

        // Navigation Property
        public Patient Patient { get; set; } = null;

        public decimal TotalAmount { get; set; }
        public string PaymentStatus { get; set; } = "Unpaid"; // Unpaid, Paid, Cancelled
        public DateTime IssueDate { get; set; } = DateTime.UtcNow;
        public DateTime DueDate { get; set; }

    }
}
