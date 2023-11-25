﻿namespace AutoLot.Services.DataServices.Dal;
public class CarDalDataService : DalDataServiceBase<Car, CarDalDataService>, ICarDataService
{
    private readonly ICarRepo _repo;
    public CarDalDataService(IAppLogging<CarDalDataService> appLogging, ICarRepo repo) 
        : base(appLogging, repo)
    {
        _repo = repo;
    }

    public async Task<IEnumerable<Car>> GetAllByMakeIdAsync(int? makeId) 
        => makeId.HasValue ? _repo.GetAllBy(makeId.Value) : _repo.GetAllIgnoreQueryFilters();

    public async Task<Car> LoadRelatedMakeAsync(Car car)
    {
        await MainRepo.Context.Entry(car).Reference(c => c.MakeNavigation).LoadAsync();
        return car;
    }
}
