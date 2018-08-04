using Microsoft.Extensions.DependencyInjection;
using System;

namespace Pat.Subscriber.NetCoreDependencyResolution
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddPatSubscriber(this IServiceCollection services, Action<Options> options)
        {
            var optionsBuilder = new Options(new ServiceRegistrar(services));
            options(optionsBuilder);

            return services;
        }
    }
}
