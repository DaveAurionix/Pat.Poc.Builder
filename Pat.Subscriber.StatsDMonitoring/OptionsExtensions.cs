namespace Pat.Subscriber.StatsDMonitoring
{
    public static class OptionsExtensions
    {
        public static Options UseStatsDMonitoring(this Options optionsBuilder)
            => optionsBuilder
                .UseMessageBehaviour<MessageBehaviour>()
                .UseBatchBehaviour<BatchBehaviour>()
                .UseServices(s => s
                    .AddSingleton<MessageBehaviour>()
                    .AddSingleton<BatchBehaviour>());
    }
}
