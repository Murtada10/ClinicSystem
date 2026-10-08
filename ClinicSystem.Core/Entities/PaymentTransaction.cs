using ClinicSystem.Core.Common;
using ClinicSystem.Core.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicSystem.Core.Entities
{
    public class PaymentTransaction : AuditableEntity
    {
        // Foreign Key
        public int InvoiceId { get; set; }

        // Navigation Property
        public Invoice Invoice { get; set; } = null!;

        public decimal AmountPaid { get; set; }
        public PaymentMethod Method { get; set; } // Uses the Enum we just created
        public DateTime TransactionDate { get; set; } = DateTime.UtcNow;
        public string ReferenceNumber { get; set; } = string.Empty;
    }
}
