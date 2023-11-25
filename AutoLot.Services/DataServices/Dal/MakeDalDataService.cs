namespace AutoLot.Services.DataServices.Dal;
public class MakeDalDataService : DalDataServiceBase<Make, MakeDalDataService>, IMakeDataService
{
    public MakeDalDataService(IAppLogging<MakeDalDataService> appLogging, IMakeRepo repo) 
        : base(appLogging, repo) { }

    public Make GetMakeByCar(Car car)
    {
        MainRepo.Context.Entry(car).Reference(c => c.MakeNavigation).Load();
        return car.MakeNavigation;
    }
}
