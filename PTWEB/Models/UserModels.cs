using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PTWEB.Models
{
    public class RegisterModels
    {
        [Required]
        public String ID { get; set; }
        [Required]
        public String UserName { get; set; }
        [Required]
        public String Email { get; set; }
        [Required]
        [MinLength(6, ErrorMessage = "Password must be at least 6 characters long.")]
        public String Password { get; set; }
        [Required]
        [Compare("Password", ErrorMessage = "Does not match password field.")]
        public String ConfirmPassword { get; set; }
        [Required]
        public String PhoneNumber { get; set; }
        [Required]
        public String Address { get; set; }
        [Required]
        public DateTime DoB { get; set; }
    }

    public class LoginModels
    {
        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    } 
}