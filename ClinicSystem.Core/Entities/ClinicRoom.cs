using ClinicSystem.Core.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicSystem.Core.Entities
{
    public class ClinicRoom : AuditableEntity
    {
        public string RoomNumber { get; set; } = string.Empty;
        public string Roomtype { get; set; } = string.Empty;
        public bool IsAvailable { get; set; } = true;

    }
}
