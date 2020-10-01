using System.Linq;
using System.Reflection;
using Autofac;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NLog;
using NLog.Config;
using NLog.Targets;

namespace LogModule.UnitTests
{
	[TestClass]
	public class AssemblyResolvingTests
	{
		public TestContext TestContext { get; set; }

		private static IContainer _container;

		[ClassInitialize()]
		public static void SetUp(TestContext testContext)
		{
			BuildSampleContainer();
			Assert.IsNotNull(_container);
		}

		[ClassCleanup]
		public static void Cleanup()
		{
			_container.Dispose();
			_container = null;
		}

		//Контейнер
		private static void BuildSampleContainer()
		{
			var builder = new ContainerBuilder();
			var dataAccess = Assembly.GetExecutingAssembly().GetReferencedAssemblies();

			builder.RegisterAssemblyModules(
				dataAccess
					.Select(ass => Assembly.Load(ass))
					.ToArray());
			
			builder.RegisterType<TestClass>().AsSelf();
		
			_container = builder.Build();
		}


		[TestMethod]
		public void ResolveFromAssemblyTest()
		{
			var test = _container.Resolve<TestClass>();
			Assert.IsNotNull(test);


			// Step 1.Create configuration object

			var config = new LoggingConfiguration();

			// Step 2. Create targets and add them to the configuration

			var target = new ConsoleTarget();
			config.AddTarget("console", target);

			// Step 3. Set target properties
			// Step 4. Define rules

			LoggingRule rule1 = new LoggingRule("*", LogLevel.Trace, target);
			config.LoggingRules.Add(rule1);
			//config.LoggingRules.Remove(rule);

			// Step 5. Activate the configuration

			LogManager.Configuration = config;

			test.Trace();
		}
	}
}
