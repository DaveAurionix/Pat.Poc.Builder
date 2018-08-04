using Pat.Subscriber.DependencyInjection;
using StructureMap;
using StructureMap.Pipeline;

namespace Pat.Subscriber.StructureMap4DependencyResolution
{
    class ServiceRegistrar : IServiceRegistrar
    {
        private readonly ConfigurationExpression configuration;

        public ServiceRegistrar(ConfigurationExpression configuration)
        {
            this.configuration = configuration;
        }

        public IServiceRegistrar AddSingleton<T>()
            where T : class
        {
            configuration.ForSingletonOf<T>().Use<T>();
            return this;
        }

        public IServiceRegistrar AddSingleton<T>(T instance)
            where T : class
        {
            configuration.ForSingletonOf<T>().Use(instance);
            return this;
        }

        public IServiceRegistrar AddTransient<I, T>()
            where T : class, I
            where I : class
        {
            configuration.For<T>().LifecycleIs<TransientLifecycle>().Use<T>();
            return this;
        }
    }
}
