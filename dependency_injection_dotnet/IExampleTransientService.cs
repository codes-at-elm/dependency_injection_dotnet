using Microsoft.Extensions.DependencyInjection;

namespace dependency_injection_dotnet;

public interface IExampleTransientService : IReportServiceLifetime
{
    ServiceLifetime IReportServiceLifetime.Lifetime => ServiceLifetime.Transient;
}