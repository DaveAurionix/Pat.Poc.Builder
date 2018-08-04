using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;

namespace Pat.ExampleSubscriber
{
    class Program
    {
        async static Task Main(string[] args)
        {
            var services = Dependencies.Install();

            var subscriber = services.GetRequiredService<Subscriber.Subscriber>();
            await subscriber.Initialise();
            await subscriber.ListenForMessages();
        }
    }
}
