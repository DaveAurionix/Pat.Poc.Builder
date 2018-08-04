using StructureMap;
using System.Threading.Tasks;

namespace Pat.ExampleSubscriber.StructureMap
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var container = Dependencies.Install();

            var subscriber = container.GetInstance<Subscriber.Subscriber>();
            await subscriber.Initialise();
            await subscriber.ListenForMessages();
        }
    }
}
