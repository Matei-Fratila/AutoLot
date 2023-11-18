namespace AutoLot.Services.DataServices.Dal;
public class MakeDalDataService : DalDataServiceBase<Make>, IMakeDataService
{
    public MakeDalDataService(IMakeRepo repo) : base(repo) { }
}
