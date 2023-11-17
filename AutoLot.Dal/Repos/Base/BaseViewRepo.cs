
namespace AutoLot.Dal.Repos.Base;
public abstract class BaseViewRepo<T> : IBaseViewRepo<T> 
    where T : class, new()
{
    private readonly bool _disposeContext;
    public ApplicationDbContext Context { get; }

    public DbSet<T> Table { get; }

    protected BaseViewRepo(ApplicationDbContext context)
    {
        Context = context;
        Table = Context.Set<T>();
        _disposeContext = false;
    }

    protected BaseViewRepo(DbContextOptions<ApplicationDbContext> options) : this(new ApplicationDbContext(options))
    {
        _disposeContext = true;
    }

    ~BaseViewRepo() 
    {
        Dispose(false);
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    private bool _isDisposed;
    protected virtual void Dispose(bool disposing)
    {
        if (_isDisposed)
        {
            return;
        }
        if (disposing)
        {
            if (_disposeContext)
            {
                Context.Dispose();
            }
        }
        _isDisposed = true;
    }

    public virtual IEnumerable<T> ExecuteSqlString(string sql) => Table.FromSqlRaw(sql);

    public virtual IEnumerable<T> GetAll() => Table.AsQueryable();

    public virtual IEnumerable<T> GetAllIgnoreQueryFilters() => Table.AsQueryable().IgnoreQueryFilters();
}
