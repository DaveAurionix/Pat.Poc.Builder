namespace Pat.Subscriber.CircuitBreaker
{
    public static class OptionsExtensions
    {
        public static Options UseCircuitBreaker(this Options optionsBuilder, CircuitBreakerOptions circuitBreakerOptions = null)
            => optionsBuilder
                .UseMessageBehaviour<CircuitBreakerMessageProcessingBehaviour>()
                .UseBatchBehaviour<CircuitBreakerBatchProcessingBehaviour>()
                .UseServices(s => s
                    .AddSingleton(circuitBreakerOptions ?? new CircuitBreakerOptions())
                    .AddSingleton<CircuitBreakerMessageProcessingBehaviour>()
                    .AddSingleton<CircuitBreakerBatchProcessingBehaviour>());
    }
}
