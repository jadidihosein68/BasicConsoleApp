using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using MyBasicConsoleApp.Core;
using MyBasicConsoleApp.Service1.Adapter;
using MyBasicConsoleApp.Service1.Application;
using MyBasicConsoleApp.Service1.Repository;
using MyBasicConsoleApp.Service1.Utility;
using System;

namespace MyBasicConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceProvide = new ServiceCollection();
            ConfigureServices(serviceProvide);
            ConfigureLogs(serviceProvide);

            serviceProvide.BuildServiceProvider().GetService<IStartup>().DoWork(args);
        }

        public static void ConfigureServices(IServiceCollection service)
        {

            service.AddSingleton<IStartup, Startup>()
            .AddTransient<IAdapter1, Adapter1>()
            .AddTransient<IRepository1, Repository1>()
            .AddTransient<IApplication1, Application1>()
            .AddTransient<IUtility1, Utility1>();

        }


        public static void ConfigureLogs(IServiceCollection service)
        {
            service.AddLogging(configure => configure.AddConsole())
            .AddTransient<Adapter1>();
        }




    }
}
