using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicSystem.Services
{
    public interface IBillingEngine
    {
        Task<decimal> CalculateTotalFeesAsync(int patientId);
        Task<bool> ProcessPaymentAsync(int patientId, decimal amount);
    }
}
