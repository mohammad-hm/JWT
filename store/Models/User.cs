using System.ComponentModel.DataAnnotations;


namespace store.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(255)]
        public string Username { get; set; } = string.Empty;

        // Add other user properties as needed
    }
}
