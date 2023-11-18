namespace AutoLot.Services.DataServices.Api;
public class CarApiDataService : ApiDataServiceBase<Car>, ICarDataService
{
    public CarApiDataService() : base()
    {
        
    }

    public async Task<IEnumerable<Car>> GetAllByMakeIdAsync(int? makeId) 
        => throw new NotImplementedException();
}
