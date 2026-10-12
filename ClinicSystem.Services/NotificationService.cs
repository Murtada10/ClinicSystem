using ClinicSystem.Core.Interfaces;
using System;
using System.Threading.Tasks;

namespace ClinicSystem.Services
{
    public class NotificationService : INotificationService
    {
        public async Task<bool> SendSmsAsync(string phoneNumber, string message)
        {
            Console.WriteLine($"\n[NETWORK LOG] Connecting to SMS Gateway for {phoneNumber}...");

            // Simulating a network delay to an external SMS provider (like Twilio)
            await Task.Delay(500);

            Console.WriteLine($"[SMS SENT] To: {phoneNumber} | Message: {message}");
            return true;
        }

        public async Task<bool> SendEmailAsync(string emailAddress, string subject, string body)
        {
            Console.WriteLine($"\n[NETWORK LOG] Connecting to SMTP Server for {emailAddress}...");

            // Simulating a network delay to an external Email provider (like SendGrid)
            await Task.Delay(800);

            Console.WriteLine($"[EMAIL SENT] To: {emailAddress} | Subject: {subject}");
            return true;
        }
    }
}