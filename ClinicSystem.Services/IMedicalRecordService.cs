using System.Collections.Generic;
using System.Threading.Tasks;
using ClinicSystem.Core.Entities;

namespace ClinicSystem.Services
{
    public interface IMedicalRecordService
    {
        Task<IEnumerable<MedicalRecord>> GetPatientRecordsAsync(int patientId, int requestingDoctorId);
        Task<bool> AddSecureRecordAsync(MedicalRecord medicalRecord, int requestingDoctorId);

    }
}
