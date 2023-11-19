namespace AutoLot.Services.DataServices.Api;
public class MakeApiDataService : ApiDataServiceBase<Make>, IMakeDataService
{
    public MakeApiDataService(IMakeApiServiceWrapper serviceWrapper) : base(serviceWrapper)
    {
        
    }
}
