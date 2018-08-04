using Pat.Subscriber.DependencyInjection;
using System;
using System.Collections.Generic;

namespace Pat.Subscriber
{
    public class Options
    {
        private Type deserialiserType;
        private readonly List<Type> messageProcessingBehaviours = new List<Type>();
        private readonly List<Type> batchProcessingBehaviours = new List<Type>();
        private readonly IServiceRegistrar serviceRegistrar;

        public Options(IServiceRegistrar serviceRegistrar)
        {
            this.serviceRegistrar = serviceRegistrar;
        }

        public Options UseDeserialiser<T>()
            where T : IMessageDeserialiser
        {
            deserialiserType = typeof(T);
            return this;
        }

        public Options UseMessageBehaviour<T>()
            where T : IMessageProcessingBehaviour
        {
            messageProcessingBehaviours.Add(typeof(T));
            return this;
        }

        public Options UseBatchBehaviour<T>()
            where T : IBatchProcessingBehaviour
        {
            messageProcessingBehaviours.Add(typeof(T));
            return this;
        }

        public Options UseServices(Action<IServiceRegistrar> serviceRegistrator)
        {
            serviceRegistrator(serviceRegistrar);
            return this;
        }

        public void Register()
        {
            serviceRegistrar
                .AddSingleton<Subscriber>()
                .AddTransient<IMessageProcessor, MessageProcessor>();

            // etc. for all of Pat's internals
            // also call to methods in pipeline builder classes to assemble message and batch behaviour chains from the types above
        }
    }
}
