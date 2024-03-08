using Microsoft.Extensions.DependencyInjection;

namespace dependency_injection_dotnet;

public interface IReportServiceLifetime
{
    Guid Id { get; }

    ServiceLifetime Lifetime { get; }
}