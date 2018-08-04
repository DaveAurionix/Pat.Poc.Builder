using Microsoft.Extensions.DependencyInjection;
using Pat.Subscriber.DependencyInjection;

namespace Pat.Subscriber.NetCoreDependencyResolution
{
    class ServiceRegistrar : IServiceRegistrar
    {
        private readonly IServiceCollection services;

        public ServiceRegistrar(IServiceCollection services)
        {
            this.services = services;
        }

        public IServiceRegistrar AddSingleton<T>()
            where T : class
        {
            services.AddSingleton<T>();
            return this;
        }

        public IServiceRegistrar AddSingleton<T>(T instance)
            where T : class
        {
            services.AddSingleton(instance);
            return this;
        }

        public IServiceRegistrar AddTransient<I, T>()
            where T : class, I
            where I : class
        {
            services.AddTransient<I, T>();
            return this;
        }
    }
}
