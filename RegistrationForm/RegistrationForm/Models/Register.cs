using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace RegistrationForm.Models
{
    public class Register 
    {
        [Required(ErrorMessage = "Name is required.")]
        [RegularExpression(@"^[A-Za-z]+$",
            ErrorMessage = "Nmae must contain only alphabets ")]

        public string Name { get; set; }

        [Required(ErrorMessage = "Email is Required ")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]

        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$%*!?&]).{6,}$",
            ErrorMessage = "Password must be exactly 6 characters long and include at least one uppercase letter, one lowercase letter, one digit, and one special character (@, $, %, *, !, ?, &).")]

        
        public string Password { get; set; }
        [Required(ErrorMessage = "Age is required ")]
        [Range (18,60,ErrorMessage = "Age must be between 18 and 60")]

        public int Age { get; set; }


    }
}
