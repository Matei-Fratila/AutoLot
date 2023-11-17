namespace AutoLot.Dal.Tests;
public static class TestHelpers
{
    public static IConfiguration GetConfiguration() =>
        new ConfigurationBuilder()
        .SetBasePath(Directory.GetCurrentDirectory())
        .AddJsonFile("appsettings.testing.json", true, true)
        .Build();

    public static ApplicationDbContext GetContext(IConfiguration configuration)
    {
        var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
        var connectionString = configuration.GetConnectionString("AutoLot");
        optionsBuilder.UseSqlServer(connectionString);
        return new ApplicationDbContext(optionsBuilder.Options);
    }

    /// <summary>
    /// creating an instance of the ApplicationDbContext class from an existing instance to share the connection and transaction
    /// </summary>
    /// <param name="oldContext"></param>
    /// <param name="trans"></param>
    /// <returns></returns>
    public static ApplicationDbContext GetSecondContext(ApplicationDbContext oldContext, IDbContextTransaction trans)
    {
        var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
        optionsBuilder.UseSqlServer(oldContext.Database.GetDbConnection());
        var context = new ApplicationDbContext(optionsBuilder.Options);
        context.Database.UseTransaction(trans.GetDbTransaction());
        return context;
    }

}
