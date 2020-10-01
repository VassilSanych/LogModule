
using System.Diagnostics;
using Autofac;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NLog;
using NLog.Config;
using NLog.Targets;
using VGn.LogModule;

namespace LogModule.UnitTests
{
	public class TestClass
	{
		private ILogger _logger;

		public TestClass(ILogger logger)
		{
			Assert.IsNotNull(logger);
			_logger = logger;
		}

		public void Trace()
		{
			_logger.Trace("Hello World");
		}
	}


	[TestClass]
	public class ResolvingTests
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

			//builder.RegisterType<NLogMiddleware>();
			builder.RegisterModule<NLogModule>();

			//builder.RegisterType<TestThrowLogger>().As<ILogger>();

			builder.RegisterType<TestClass>().AsSelf();


			
			_container = builder.Build();
		}


		[TestMethod]
		public void ResolvingTest()
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
