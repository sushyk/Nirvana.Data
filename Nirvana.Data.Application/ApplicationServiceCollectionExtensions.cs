using FluentValidation;
using Microsoft.Extensions.DependencyInjection;

namespace Nirvana.Data.Application;

public static class ApplicationServiceCollectionExtensions
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        var assembly = typeof(ApplicationServiceCollectionExtensions).Assembly;

        services.AddMediatR(configuration =>
            configuration.RegisterServicesFromAssemblies(assembly));

        services.AddValidatorsFromAssembly(assembly);

        return services;

    }
}
