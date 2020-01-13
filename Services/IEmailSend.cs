using System.Threading.Tasks;

namespace CourseProjectApp.Services
{
    public interface IEmailSend
    {
        Task SendEmailAsync(string email, string subject, string message);
    }
}
