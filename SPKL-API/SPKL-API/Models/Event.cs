namespace SPKL_API.Models
{
    public class Event
    {
        public Guid Id { get; set; }
        public Guid Name { get; set; }
        public Guid Description { get; set; }
        public EventType EventType { get; set; }
    }
}
