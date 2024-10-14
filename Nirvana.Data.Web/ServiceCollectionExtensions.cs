using Nirvana.Data.Presentation;
using Nirvana.Data.Application;
using Nirvana.Data.Infrastructure;

namespace Nirvana.Data.Web;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection RegisterAllDependencies(this IServiceCollection services)
    {
        services
            .AddApplication()
            .AddInfrastructure()
            .AddPresentation()
            .AddControllers()
            .AddApplicationPart(typeof(PresentationServiceCollectionExtensions).Assembly);

        return services;
    }
}
