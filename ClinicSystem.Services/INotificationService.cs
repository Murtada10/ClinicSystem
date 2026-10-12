using System.Threading.Tasks;

namespace ClinicSystem.Core.Interfaces
{
    public interface INotificationService
    {
        Task<bool> SendSmsAsync(string phoneNumber, string message);
        Task<bool> SendEmailAsync(string emailAddress, string subject, string body);
    }
}