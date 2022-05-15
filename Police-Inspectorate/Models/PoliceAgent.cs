using System.ComponentModel.DataAnnotations;

namespace Police_Inspectorate.Models
{
    public class PoliceAgent
    {
        public Guid Id { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public int StationNumber { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        public bool StationChief { get; set; }
        public ICollection<Meeting>? Meetings { get; set; }
        public ICollection<Request>? Requests { get; set; }
    }
}
