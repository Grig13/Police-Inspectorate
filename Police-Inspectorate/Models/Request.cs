using System.ComponentModel.DataAnnotations;

namespace Police_Inspectorate.Models
{
    public class Request
    {
        public Guid Id { get; set; }
        [Required]
        public string Reason { get; set; }
        [Required]
        public bool Response { get; set; }
    }
}
