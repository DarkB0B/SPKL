namespace SPKL_API.Models;

public abstract class Results
{
    public Driver Driver { get; set; }
    public Track Track { get; set; }
    public IEnumerable<TimeSpan> Times { get; set; }
    public TimeSpan BestLap => Times.Min();    
}