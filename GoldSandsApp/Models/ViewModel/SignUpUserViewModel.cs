using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GoldSandsApp.Models.ViewModel
{
    public class SignUpUserViewModel
    {
        [Required(ErrorMessage = "Name should not be empty")]
        [RegularExpression(@"^[a-zA-Z0-9]+$", ErrorMessage = "Special character should not be entered")]
        [DisplayName("User Name")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Email should not be empty")]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "E-mail is not valid")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Phone Number should not be empty")]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{5})$", ErrorMessage = "Entered phone Number format is not valid.")]
        [StringLength(11, MinimumLength = 11, ErrorMessage = "Contact number should have minimum 11 digits")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Password is Required")]
        [DisplayName("Password")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)\S{6,20}$", ErrorMessage = "Invalid Password")]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "Password Not Matched!")]
        [DisplayName("Confirm Password")]
        public string ConfirmPassword { get; set; }
    }
}
