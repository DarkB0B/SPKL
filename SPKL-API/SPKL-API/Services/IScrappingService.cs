using SPKL_API.Models;

namespace SPKL_API.Services;

public interface IScrappingService
{
    public IEnumerable<Result> FetchDataFromEmailEnumerable(string email);
}