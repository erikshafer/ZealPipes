using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ZealPipes.Esdb;

public static class ModuleRegistry
{
    public static IServiceCollection AddEventStoreDb(IServiceCollection services, IConfiguration config)
    {
        // TODO: add to config of an app: { "EventStore": "esdb://localhost:2113?tls=false" }
        const string connectionString = "esdb://admin:changeit@localhost:2113?tls=false&tlsVerifyCert=false";
        services.AddEventStoreClient(new Uri(connectionString));
        
        return services;
    }
}