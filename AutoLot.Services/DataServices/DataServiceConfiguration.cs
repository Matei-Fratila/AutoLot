using AutoLot.Dal.Repos.Interfaces;

namespace AutoLot.Services.DataServices;
public static class DataServiceConfiguration
{
    public static IServiceCollection AddRepositories(this IServiceCollection services)
    {
        services.AddScoped<ICarDriverRepo, CarDriverRepo>();
        services.AddScoped<ICarRepo, CarRepo>();
        services.AddScoped<ICreditRiskRepo, CreditRiskRepo>();
        services.AddScoped<ICustomerOrderViewModelRepo, CustomerOrderViewModelRepo>();
        services.AddScoped<ICustomerRepo, CustomerRepo>();
        services.AddScoped<IDriverRepo, DriverRepo>();
        services.AddScoped<IMakeRepo, MakeRepo>();
        services.AddScoped<IOrderRepo, OrderRepo>();
        services.AddScoped<IRadioRepo, RadioRepo>();
        return services;
    }
}
