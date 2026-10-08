using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicSystem.Core
{
    public class Doctor : Person
    {
        public string Specialization { get; set; } = string.Empty;
        public string LicenseNumber { get; set; } = string.Empty;
        public decimal ConsultationFee { get; set; }


        public ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();
    }
}
