using System.ComponentModel.DataAnnotations;

namespace CourseProjectApp.ViewModels
{
    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

    }
}
