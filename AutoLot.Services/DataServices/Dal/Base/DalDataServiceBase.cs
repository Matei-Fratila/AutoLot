namespace AutoLot.Services.DataServices.Dal.Base;
public abstract class DalDataServiceBase<TEntity> : IDataServiceBase<TEntity> 
    where TEntity : BaseEntity, new()
{
    protected readonly IBaseRepo<TEntity> MainRepo;
    protected DalDataServiceBase(IBaseRepo<TEntity> mainRepo)
    {
        MainRepo = mainRepo;
    }

    public async Task<IEnumerable<TEntity>> GetAllAsync()
        => MainRepo.GetAllIgnoreQueryFilters();

    public async Task<TEntity> FindAsync(int id)
        => await MainRepo.FindAsync(id);

    public async Task<TEntity> AddAsync(TEntity entity, bool persist = true)
        => await MainRepo.AddAsync(entity, persist);

    public async Task DeleteAsync(TEntity entity, bool persist = true)
        => await MainRepo.DeleteAsync(entity, persist);

    public async Task<TEntity> UpdateAsync(TEntity entity, bool persist = true)
        => await MainRepo.UpdateAsync(entity, persist);

    public void ResetChangeTracker()
    {
        MainRepo.Context.ChangeTracker.Clear();
    }
}
