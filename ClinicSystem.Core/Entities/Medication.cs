using ClinicSystem.Core.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicSystem.Core.Entities
{
    public class Medication : AuditableEntity
    {
        public string Name { get; set; } = string.Empty;
        public string Dosage { get; set; } = string.Empty;
        public string Manufacturer { get; set; } = string.Empty;
        public int StockQuantiy { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
