using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;
using System.Threading;

namespace PizzaPizza
{
	[TestFixture(Platform.Android)]
	[TestFixture(Platform.iOS)]
	public class Tests
	{
		IApp app;
		Platform platform;

		public Tests(Platform platform)
		{
			this.platform = platform;
		}

		[SetUp]
		public void BeforeEachTest()
		{
			app = AppInitializer.StartApp(platform);
			app.Device.SetLocation(43.640687, -79.407593);
		}

		[Test]
		public void FirstTest()
		{
			app.Repl();
		}


		[Test]
		public void PizzaTest()
		{
			app.Tap("OK");
			Thread.Sleep(10000);
			app.Tap("LOCATE BY POSTAL CODE");
			app.Screenshot("Then we Tapped on 'Postal Code'");

		}


	}
}
