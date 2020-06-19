using System.ComponentModel.DataAnnotations;
using WebAppValidations.CustomAttributes;

namespace WebAppValidations.Models
{
    public class UserViewModel
    {
        [Required(ErrorMessage = "Please Enter Name")]
        [MinLength(5)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please Enter Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please Enter Password")]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "Please Enter Confirm Password")]
        public string ConfirmPassword { get; set; }

        public string Address { get; set; }

        [RegularExpression(@"^[6,7,8,9]\d{9}", ErrorMessage = "Please Enter Contact")]
        public string Contact { get; set; }

        [ValidateCheckbox(ErrorMessage = "Please Accept Terms")]
        public bool Terms { get; set; }
    }
}
