using Microsoft.Extensions.DependencyInjection;

namespace dependency_injection_dotnet;

public interface IExampleScopedService : IReportServiceLifetime
{
    ServiceLifetime IReportServiceLifetime.Lifetime => ServiceLifetime.Scoped;
}