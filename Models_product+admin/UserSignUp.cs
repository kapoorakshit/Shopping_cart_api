using System.ComponentModel.DataAnnotations;

namespace Core_Assingment_Api.Model
{
    public class UserSignUp
    {
        public string UserId { get; set; }

        [Required(ErrorMessage = "required Name")]
        [StringLength(100)]
        public string UserName { get; set; }

        [EmailAddress(ErrorMessage = "email address required")]
        [Required(ErrorMessage = "email  required")]
        public string Email { get; set; }
        [Required(ErrorMessage = "required password")]
        public string Password { get; set; }

        [Required(ErrorMessage = "required Confirm password")]
        [Compare("Password", ErrorMessage = "The Password and Confirm Password do not match.")]
        public string ConfirmPassword { get; set; }
        
    }
}
