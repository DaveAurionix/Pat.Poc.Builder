using StructureMap;
using System;

namespace Pat.Subscriber.StructureMap4DependencyResolution
{
    public static class ConfigurationExpressionExtensions
    {
        public static ConfigurationExpression AddPatSubscriber(this ConfigurationExpression configuration, Action<Options> options)
        {
            var optionsBuilder = new Options(new ServiceRegistrar(configuration));
            options(optionsBuilder);

            return configuration;
        }
    }
}
