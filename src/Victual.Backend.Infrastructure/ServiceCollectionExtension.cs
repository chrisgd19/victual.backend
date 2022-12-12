using System.Data;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.DependencyInjection;
using Victual.Backend.Infrastructure.Internal;

namespace Victual.Backend.Infrastructure;

public static class ServiceCollectionExtension
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, InfrastructureConfiguration configuration)
    {
        return services
            .AddScoped<IDbTransaction>(_ =>
            {
                var connection = new SqlConnection(configuration.DatabaseConnectionString);
                connection.Open();

                return connection.BeginTransaction();
            })
        .AddScoped<IConnection>(serviceProvider => new Connection(serviceProvider.GetRequiredService<IDbTransaction>()));
    }
}