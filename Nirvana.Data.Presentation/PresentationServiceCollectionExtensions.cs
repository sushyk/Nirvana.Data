using Microsoft.Extensions.DependencyInjection;

namespace Nirvana.Data.Presentation;

public static class PresentationServiceCollectionExtensions
{
    public static IServiceCollection AddPresentation(this IServiceCollection services)
    {
        services
             .AddControllers()
             .AddApplicationPart(typeof(PresentationServiceCollectionExtensions).Assembly);

        return services;
    }
}
