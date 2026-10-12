using ClinicSystem.Core.Entities;
using ClinicSystem.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicSystem.Services
{
    public class BillingEngine : IBillingEngine
    {
        private readonly IUnitOfWork _unitOfWork;

        // Dependency Injection: Injecting IUnitOfWork as per Blueprint Line 36
        public BillingEngine(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<decimal> CalculateTotalFeesAsync(int patientId)
        {
            Console.WriteLine($"\n[BillingEngine] Calculating fees for Patient ID: {patientId}...");

            // Simulating a database read to get all unpaid services for the patient
            await Task.Delay(300);

            // Business Logic: Calculating base fees + 15% VAT
            decimal baseConsultationFee = 150.00m;
            decimal taxRate = 0.15m;

            decimal totalFee = baseConsultationFee + (baseConsultationFee * taxRate);

            return totalFee;

        }

        public async Task<bool> ProcessPaymentAsync(int patientId, decimal amount)
        {
            Console.WriteLine($"[BillingEngine] Connecting to payment gateway for {amount:C}...");

            // Simulating external network call to a payment provider (like Stripe)
            await Task.Delay(500);

            // In a complete implementation, this is where IUnitOfWork shines:
            // await _unitOfWork.Payments.AddAsync(newPaymentRecord);
            // await _unitOfWork.Appointments.UpdateStatusAsync(patientId, "Paid");
            // await _unitOfWork.CompleteAsync(); // Saves EVERYTHING or rolls back if it fails!

            Console.WriteLine("[BillingEngine] Payment processed and database transaction complete.");
            return true;

        }
    }
}
