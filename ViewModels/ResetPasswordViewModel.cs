using System.ComponentModel.DataAnnotations;

namespace CourseProjectApp.ViewModels
{
    public class ResetPasswordViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [StringLength(60,ErrorMessage = "The Password must be between 6 and 60 characters long.",MinimumLength = 6)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name="Confirm Password")]
        [Compare("Password",ErrorMessage = "The password and the confirmation password must match each other.")]
        public string ConfirmPassword { get; set; }

        public string Code { get; set; }
    }
}
