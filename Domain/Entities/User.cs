using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class User : BaseEntity
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }

        public string Address { get; set; }

        [Required]
        public string PhoneNumber { get; set; }

        [Required]
        public string Role { get; set; }

        public DateTime Birthday { get; set; }

        public string? Description { get; set; }
    }
}
