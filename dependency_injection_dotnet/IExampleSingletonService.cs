using Microsoft.Extensions.DependencyInjection;

namespace dependency_injection_dotnet;

public interface IExampleSingletonService : IReportServiceLifetime
{
    ServiceLifetime IReportServiceLifetime.Lifetime => ServiceLifetime.Singleton;
}