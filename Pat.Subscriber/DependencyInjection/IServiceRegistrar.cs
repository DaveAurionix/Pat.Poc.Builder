namespace Pat.Subscriber.DependencyInjection
{
    public interface IServiceRegistrar
    {
        IServiceRegistrar AddSingleton<T>()
            where T : class;

        IServiceRegistrar AddSingleton<T>(T instance)
            where T : class;

        IServiceRegistrar AddTransient<I, T>()
            where T : class, I
            where I : class;
    }
}
