namespace AutoLot.Dal.Repos;
public class MakeRepo : TemporalTableBaseRepo<Make>, IMakeRepo
{
    public MakeRepo(ApplicationDbContext context) : base(context)
    {
    }
    internal MakeRepo(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    internal IOrderedQueryable<Make> BuildBaseQuery()
        => Table.OrderBy(x => x.Name);

    public override IEnumerable<Make> GetAll()
        => BuildBaseQuery();

    public override IEnumerable<Make> GetAllIgnoreQueryFilters()
        => BuildBaseQuery().IgnoreQueryFilters();
}
