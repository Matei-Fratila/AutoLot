namespace AutoLot.Services.DataServices.Api;
public class CarApiDataService : ApiDataServiceBase<Car, CarApiDataService>, ICarDataService
{
    public CarApiDataService(IAppLogging<CarApiDataService> appLogging
        , ICarApiServiceWrapper serviceWrapper) 
        : base(appLogging, serviceWrapper)
    {
        
    }

    public async Task<IEnumerable<Car>> GetAllByMakeIdAsync(int? makeId)
        => makeId.HasValue ? await ((ICarApiServiceWrapper)ServiceWrapper).GetCatsByMakeAsync(makeId.Value)
            : await GetAllAsync();
}
