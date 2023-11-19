namespace AutoLot.Services.ApiWrapper.Interfaces;
public interface ICarApiServiceWrapper : IApiServiceWrapperBase<Car>
{
    Task<IList<Car>> GetCatsByMakeAsync(int id);
}
