using System.Threading.Tasks;

namespace CourseProjectApp.Services
{
   public interface ISmsSend
   {
       Task SendSmsAsync(string number, string message);
   }
}
