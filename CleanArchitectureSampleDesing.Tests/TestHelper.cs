using Framework.DependencyConfig;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureSampleDesing.Tests
{
    public static class TestHelper
    {
        public static ServiceCollection Services { get; private set; }
        public static ServiceProvider ServiceProvider { get; private set; }
        static TestHelper()
        {
            Services = new ServiceCollection();
            
        }
        public static void DoConfiguration()
        {
            var configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();
            ServiceProvider = ApplicationConfig.DoConfig(Services, configuration);
        }
        public static void DoTryCatchAssert(Action action)
        {
            bool status = false;
            try
            {
                action();
                status = true;
            }
            catch (Exception)
            {
                status = false;
            }
            Assert.IsTrue(status);
        }
    }
}
