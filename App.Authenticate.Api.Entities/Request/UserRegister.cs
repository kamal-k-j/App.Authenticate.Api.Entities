using System;
using System.ComponentModel.DataAnnotations;

namespace App.Authenticate.Api.Entities.Request
{
    public class UserRegister
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public DateTime DateOfBirth { get; set; }

        [Required]
        public string PhoneNumberCountry { get; set; }

        [Required]
        public string PhoneNumber { get; set; }
    }
}