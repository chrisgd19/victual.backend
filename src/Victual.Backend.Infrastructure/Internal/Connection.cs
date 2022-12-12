using System.Data;
using System.Diagnostics.CodeAnalysis;

namespace Victual.Backend.Infrastructure.Internal;

[ExcludeFromCodeCoverage]
public class Connection : IConnection
{
    private readonly IDbTransaction _transaction;

    public Connection(IDbTransaction transaction) => _transaction = transaction;
}