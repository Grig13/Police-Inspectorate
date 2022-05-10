using System.ComponentModel.DataAnnotations;

namespace Police_Inspectorate.Models
{
    public class InspectorateChief
    {
        public Guid Id { get; set; }
        [Required]
        public int UserName { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public int Age { get; set; }
    }
}
