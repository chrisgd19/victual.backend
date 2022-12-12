using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Victual.Backend.Api.Services.Mappings;

namespace Victual.Backend.Api.Services;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddServices(this IServiceCollection services)
    {
        return services
            .AddAutoMapper(typeof(ApiProfile))
            .AddMediatR(
                new[] { typeof(ServiceCollectionExtensions).Assembly },
                options => options.AsScoped());
    }
}