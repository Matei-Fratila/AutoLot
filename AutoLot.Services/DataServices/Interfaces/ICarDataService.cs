namespace AutoLot.Services.DataServices.Interfaces;
public interface ICarDataService : IDataServiceBase<Car>
{
    Task<IEnumerable<Car>> GetAllByMakeIdAsync(int? makeId);

    Task<Car> LoadRelatedMakeAsync(Car car);
}
