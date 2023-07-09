using btp_api.Models.Contracts;
using System.ComponentModel.DataAnnotations;

namespace btp_api.Models
{
    /// <summary>
    /// Used for user authentication. Not to be confused with ProjectUser.
    /// </summary>
    public class User : IEntity
    {
        [Key]
        [Required]
        [MaxLength(450)]
        public string Id { get; set; }

        [Required]
        [MaxLength(16)]
        public string UserName { get; set; }

        [Required]
        [MaxLength(256)]
        public string Email { get; set; }

        [Required]
        [MaxLength(450)]
        public string HashedPassword { get; set; }
    }
}
