using System.ComponentModel.DataAnnotations;

namespace Selfitness.Library.DbModels
{
    public class User
    {
        [Key]
        [StringLength(30, MinimumLength = 6)]
        public string Account { get; set; } = null!;

        [StringLength(50)]
        public byte[]? PasswordHash { get; set; }
    }
}
