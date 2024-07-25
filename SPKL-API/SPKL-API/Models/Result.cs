namespace SPKL_API.Models;

public class Result
{
    public Driver Driver { get; set; }
    public Track Track { get; set; }
    public IEnumerable<TimeSpan> Times { get; set; }
    public TimeSpan BestLap => Times.Min();
}