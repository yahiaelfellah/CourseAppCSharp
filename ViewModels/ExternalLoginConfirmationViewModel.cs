using System.ComponentModel.DataAnnotations;

namespace CourseProjectApp.ViewModels
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
