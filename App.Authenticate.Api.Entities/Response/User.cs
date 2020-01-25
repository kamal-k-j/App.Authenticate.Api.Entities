using System;

namespace App.Authenticate.Api.Entities.Response
{
    public class User
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Token { get; set; }

        public string PasswordHash { get; set; }

        public string HashSalt { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string PhoneNumberCountry { get; set; }

        public string PhoneNumber { get; set; }
    }
}