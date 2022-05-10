using System.ComponentModel.DataAnnotations;

namespace Police_Inspectorate.Models
{
    public class Case
    {
        public Guid Id { get; set; }
        [Required]
        public DateTime BeginDate { get; set; }
        public DateTime? EndDate { get; set; }
        [Required]
        public bool Status { get; set; }
        [Required]
        [MaxLength(500)]
        public string Description { get; set; }
        public ICollection<Suspect>? Suspects { get; set; }
        public ICollection<PoliceAgent>? Agents { get; set; }
    }
}
