namespace AutoLot.Services.DataServices.Api.Base;
public abstract class ApiDataServiceBase<TEntity> : IDataServiceBase<TEntity>
    where TEntity : BaseEntity, new()
{
    protected ApiDataServiceBase() { }

    public async Task<IEnumerable<TEntity>> GetAllAsync()
        => throw new NotImplementedException();
    public async Task<TEntity> FindAsync(int id)
        => throw new NotImplementedException();
    public async Task<TEntity> UpdateAsync(TEntity entity, bool persist = true)
    {
        throw new NotImplementedException();
    }
    public async Task DeleteAsync(TEntity entity, bool persist = true)
        => throw new NotImplementedException();
    public async Task<TEntity> AddAsync(TEntity entity, bool persist = true)
    {
        throw new NotImplementedException();
    }
}
