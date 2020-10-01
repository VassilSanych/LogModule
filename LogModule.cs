using System;
using System.Linq;
using Autofac;
using Autofac.Core;
using Autofac.Core.Registration;
using NLog;
using LogManager = NLog.LogManager;

namespace VGn.LogModule
{
    /// <summary>
    ///  Модуль autofac для подключения логирования через NLog
    /// </summary>
    /// <remarks>именование логов по типу создаваемого класса</remarks>
    public class LogModule : Module
    {
        private ILogger CreateLoggerFor(Type type)
        {
            // cut generic type trash
            var name = type.FullName?.Split('`')[0];
            return LogManager.GetLogger(name);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="componentRegistry"></param>
        /// <param name="registration"></param>
        protected override void AttachToComponentRegistration(IComponentRegistryBuilder componentRegistry, IComponentRegistration registration)
        {
	        var type = registration.Activator.LimitType;
            if (HasPropertyDependencyOnLogger(type))
                registration.Activated += InjectLoggerViaProperty;

            if (HasConstructorDependencyOnLogger(type))
                registration.Preparing += InjectLoggerViaConstructor;
        }

        private bool HasPropertyDependencyOnLogger(Type type)
        {
            return type.GetProperties()
                .Any(property => property.CanWrite && property.PropertyType == typeof(ILogger));
        }

        private bool HasConstructorDependencyOnLogger(Type type)
        {
            return type.GetConstructors()
                .SelectMany(constructor => constructor.GetParameters()
                    .Where(parameter => parameter.ParameterType == typeof(ILogger)))
                .Any();
        }

        private void InjectLoggerViaProperty(object sender, ActivatedEventArgs<object> @event)
        {
            var type = @event.Instance.GetType();
            var propertyInfo = type.GetProperties()
                .First(x => x.CanWrite && x.PropertyType == typeof(ILogger));

            propertyInfo.SetValue(@event.Instance, CreateLoggerFor(type), null);
        }

        private void InjectLoggerViaConstructor(object sender, PreparingEventArgs @event)
        {
            var type = @event.Component.Activator.LimitType;
            @event.Parameters = @event.Parameters.Union(new[]
            {
                new ResolvedParameter((parameter, context) => parameter.ParameterType == typeof(ILogger),
                    (p, i) => CreateLoggerFor(type))
            });
        }
    }
}
