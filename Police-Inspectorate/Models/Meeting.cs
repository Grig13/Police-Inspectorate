namespace Police_Inspectorate.Models
{
    public class Meeting
    {
        public Guid Id { get; set; }
        public ICollection<PoliceAgent>? Agents { get; set; }
    }
}
