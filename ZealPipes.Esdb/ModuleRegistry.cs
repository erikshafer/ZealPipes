using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ZealPipes.Esdb;

public static class ModuleRegistry
{
    public static IServiceCollection AddEventStoreDb(IServiceCollection services, IConfiguration config)
    {
        var connectionString = config["EventStore"];
        services.AddEventStoreClient(new Uri(connectionString!));
        
        return services;
    }
}