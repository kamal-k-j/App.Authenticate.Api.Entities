using System.ComponentModel.DataAnnotations;

namespace App.Authenticate.Api.Entities.Request
{
    public class UserAuthenticate
    {
        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    }
}