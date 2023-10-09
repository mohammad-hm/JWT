// Ignore Spelling: JWT

using System.ComponentModel.DataAnnotations;


namespace JWT.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(255)]
        public string UserName { get; set; } = string.Empty;


    }
}
