using System;
using System.Linq;
using System.Reflection;
using Autofac.Core;
using Autofac.Core.Registration;
using Autofac.Core.Resolving.Pipeline;
using NLog;
using LogManager = NLog.LogManager;
using Module = Autofac.Module;

namespace VGn.LogModule
{
	/// <summary>
	///  Модуль autofac для подключения логирования через NLog
	/// </summary>
	/// <remarks>именование логов по типу создаваемого класса</remarks>
	public class LogModule<T> : Module where T : IResolveMiddleware, new()
	{
		private readonly IResolveMiddleware _middleware;

		public LogModule()
		{
			_middleware = new T();
		}

		protected override void AttachToComponentRegistration(IComponentRegistryBuilder componentRegistryBuilder,
			IComponentRegistration registration)
		{
			// Attach to the registration's pipeline build.
			registration.PipelineBuilding += (sender, pipeline) =>
			{
				// Add our middleware to the pipeline.
				pipeline.Use(_middleware);
			};
		}
	}




	public class NLogMiddleware : IResolveMiddleware
	{
		public PipelinePhase Phase => PipelinePhase.ParameterSelection;

		private ILogger CreateLoggerFor(Type type)
		{
			// cut generic type trash
			var name = type.FullName?.Split('`')[0];
			return LogManager.GetLogger(name);
		}

		public void Execute(ResolveRequestContext context, Action<ResolveRequestContext> next)
		{
			// Add our parameters.
			context.ChangeParameters(context.Parameters.Union(
				new[]
				{
					new ResolvedParameter(
						(p, i) => p.ParameterType == typeof(ILogger),
						(p, i) => CreateLoggerFor(p.Member.DeclaringType)
					),
				}));

			// Continue the resolve.
			next(context);

			// Has an instance been activated?
			if (context.NewInstanceActivated)
			{
				var instanceType = context.Instance.GetType();

				// Get all the injectable properties to set.
				// If you wanted to ensure the properties were only UNSET properties,
				// here's where you'd do it.
				var properties = instanceType
					.GetProperties(BindingFlags.Public | BindingFlags.Instance)
					.Where(p => p.PropertyType == typeof(ILogger) && p.CanWrite && p.GetIndexParameters().Length == 0);

				// Set the properties located.
				foreach (var propToSet in properties)
				{
					propToSet.SetValue(context.Instance, CreateLoggerFor(instanceType), null);
				}
			}
		}
	}
}
