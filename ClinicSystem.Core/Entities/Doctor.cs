using ClinicSystem.Core.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicSystem.Core.Entities
{
    public class Doctor : Person
    {
        public string Specialization { get; set; } = string.Empty;
        public string LicenseNumber { get; set; } = string.Empty;
        public decimal ConsultationFee { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; } = null!;
        public ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();

        public ICollection<DoctorShift> Shifts { get; set; } = new List<DoctorShift>();
    }
}
