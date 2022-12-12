namespace Victual.Backend.Infrastructure;

public record InfrastructureConfiguration
{
    public string DatabaseConnectionString { get; init; }
}