namespace AutoLot.Dal.Repos.Base;
public abstract class TemporalTableBaseRepo<T> : BaseRepo<T>, ITemporalTableBaseRepo<T> 
    where T : BaseEntity, new()
{
    protected TemporalTableBaseRepo(ApplicationDbContext context) : base(context) { }
    protected TemporalTableBaseRepo(DbContextOptions<ApplicationDbContext> options)
        : this(new ApplicationDbContext(options)) { }

    public IEnumerable<TemporalViewModel<T>> GetAllHistory()
        => ExecuteQuery(Table.TemporalAll());

    public IEnumerable<TemporalViewModel<T>> GetHistoryAsOf(DateTime dateTime)
        => ExecuteQuery(Table.TemporalAsOf(ConvertToUtc(dateTime)));

    public IEnumerable<TemporalViewModel<T>> GetHistoryBetween(
    DateTime startDateTime, DateTime endDateTime)
        => ExecuteQuery(Table.TemporalBetween(ConvertToUtc(startDateTime), ConvertToUtc(endDateTime)));

    public IEnumerable<TemporalViewModel<T>> GetHistoryContainedIn(
    DateTime startDateTime, DateTime endDateTime)
        => ExecuteQuery(Table.TemporalContainedIn(ConvertToUtc(startDateTime), ConvertToUtc(endDateTime)));

    public IEnumerable<TemporalViewModel<T>> GetHistoryFromTo(DateTime startDateTime, DateTime endDateTime)
        => ExecuteQuery(Table.TemporalFromTo(ConvertToUtc(startDateTime), ConvertToUtc(endDateTime)));

    #region Helper methods
    internal static DateTime ConvertToUtc(DateTime dateTime)
        => TimeZoneInfo.ConvertTimeToUtc(dateTime, TimeZoneInfo.Local);

    /// <summary>
    /// Takes in an IQueryable<T>, adds the OrderBy clause for the ValidFrom field, and projects the results into a collection of TemporalViewModel instances
    /// </summary>
    /// <param name="query"></param>
    /// <returns></returns>
    internal static IEnumerable<TemporalViewModel<T>> ExecuteQuery(IQueryable<T> query)
        => query.OrderBy(e => EF.Property<DateTime>(e, "ValidFrom"))
                    .Select(e => new TemporalViewModel<T>
                    {
                        Entity = e,
                        ValidFrom = EF.Property<DateTime>(e, "ValidFrom"),
                        ValidTo = EF.Property<DateTime>(e, "ValidTo")
                    });
    #endregion
}
