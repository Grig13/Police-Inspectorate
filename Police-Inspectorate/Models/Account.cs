using System.ComponentModel.DataAnnotations;

namespace Police_Inspectorate.Models
{
    public class Account
    {
        public Guid Id { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
