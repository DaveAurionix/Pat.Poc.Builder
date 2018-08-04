using Pat.Subscriber;
using Pat.Subscriber.CircuitBreaker;
using Pat.Subscriber.StructureMap4DependencyResolution;
using StructureMap;

namespace Pat.ExampleSubscriber.StructureMap
{
    static class Dependencies
    {
        public static IContainer Install()
        {
            var container = new Container();

            container.Configure(config => config
                .AddPatSubscriber(options => options
                    .UseDeserialiser<SpecificMessageDeserialiser>()
                    .UseCircuitBreaker()
                    .UseStatsDMonitoring()));

            return container;
        }
    }
}
