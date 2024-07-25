namespace SPKL_API.Services;

public interface IFactoryScrappingService
{
    //some parameters to determine what system use track
    public IScrappingService GerScrappingService();
}