using SPKL_API.Models;

namespace SPKL_API.Services;

public interface ITrackService
{
    public IEnumerable<Track> GetAllTracks();
    public Track GetTrackById(Guid id);
    public IEnumerable<Driver> GetDrivers();
    public Track GetDriverById(Guid id);
    public Result GetBestTimeForTrack(Guid id);
    public Track GetBestTimeForDriver(Guid id);
}