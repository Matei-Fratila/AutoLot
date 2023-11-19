namespace AutoLot.Services.DataServices.Api;
public class CarApiDataService : ApiDataServiceBase<Car>, ICarDataService
{
    public CarApiDataService(ICarApiServiceWrapper serviceWrapper) : base(serviceWrapper)
    {
        
    }

    public async Task<IEnumerable<Car>> GetAllByMakeIdAsync(int? makeId)
        => makeId.HasValue ? await ((ICarApiServiceWrapper)ServiceWrapper).GetCatsByMakeAsync(makeId.Value)
            : await GetAllAsync();
}
