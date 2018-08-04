using System.Threading.Tasks;

namespace Pat.Subscriber
{
    public class Subscriber
    {
        public Task Initialise() => Task.CompletedTask;
        public Task ListenForMessages() => Task.CompletedTask;
    }
}
