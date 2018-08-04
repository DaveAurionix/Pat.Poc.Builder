using Microsoft.Extensions.DependencyInjection;
using Pat.Subscriber;
using Pat.Subscriber.CircuitBreaker;
using Pat.Subscriber.NetCoreDependencyResolution;
using Pat.Subscriber.StatsDMonitoring;
using System;

namespace Pat.ExampleSubscriber
{
    static class Dependencies
    {
        public static IServiceProvider Install()
        {
            var services = new ServiceCollection();

            return services
                .AddPatSubscriber(options => options
                    .UseDeserialiser<SpecificMessageDeserialiser>()
                    .UseCircuitBreaker()
                    .UseStatsDMonitoring())
                .BuildServiceProvider();
        }
    }
}
