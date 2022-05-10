using System.ComponentModel.DataAnnotations;

namespace Police_Inspectorate.Models
{
    public class Station
    {
        public Guid Id { get; set; }
        [Required]
        public string Location { get; set; }
        public ICollection<PoliceAgent>? Agents { get; set; }
    }
}
