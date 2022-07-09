using System.ComponentModel.DataAnnotations;

namespace Selfitness.MVC.Models.Account
{
    public class RegisteDTO
    {
        [Required]
        [StringLength(30, MinimumLength = 6)]
        [RegularExpression(@"^[a-zA-Z0-9](_(?!(\.|_))|\.(?!(_|\.))|[a-zA-Z0-9]){6,18}[a-zA-Z0-9]$")]
        public string Account { get; set; } = null!;

        [Required]
        [StringLength(30, MinimumLength = 8)]
        [RegularExpression("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9]).{8,30}$")]
        public string Password { get; set; } = null!;
    }
}
