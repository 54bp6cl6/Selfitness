using System.ComponentModel.DataAnnotations;

namespace Selfitness.MVC.Models.Account
{
    public class LoginDTO
    {
        [Required]
        public string Account { get; set; } = null!;

        [Required]
        public string Password { get; set; } = null!;
    }
}
