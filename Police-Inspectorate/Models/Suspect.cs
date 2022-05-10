using System.ComponentModel.DataAnnotations;

namespace Police_Inspectorate.Models
{
    public class Suspect
    {
        public Guid Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public int LastName { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        public string? Record { get; set; }
        public string? Address { get; set; }
        public ICollection<Case>? Cases { get; set; }
    }
}
