namespace AutoLot.Services.ApiWrapper.Configuration;

public static class ServiceConfiguration
{
    public static IServiceCollection ConfigureApiServiceWrapper(this IServiceCollection services, IConfiguration config)
    {
        //using the Options Pattern. Will be injected into Typed Clients and used to configre the HttpClient
        services.Configure<ApiServiceSettings>(config.GetSection(nameof(ApiServiceSettings)));
        //using Typed Clients
        services.AddHttpClient<ICarApiServiceWrapper, CarApiServiceWrapper>();
        services.AddHttpClient<IMakeApiServiceWrapper, MakeApiServiceWrapper>();
        return services;
    }
}
