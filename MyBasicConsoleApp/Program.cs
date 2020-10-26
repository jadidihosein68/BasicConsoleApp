using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using MyBasicConsoleApp.Common.Model;
using MyBasicConsoleApp.Core;
using MyBasicConsoleApp.Service1.Adapter;
using MyBasicConsoleApp.Service1.Application;
using MyBasicConsoleApp.Service1.Repository;
using MyBasicConsoleApp.Service1.Utility;
using System;
using System.IO;

namespace MyBasicConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceProvide = new ServiceCollection();

            ConfigureAddEnvironmentVariable(serviceProvide);
            ConfigureServices(serviceProvide);
            ConfigureLogs(serviceProvide);

            serviceProvide.BuildServiceProvider().GetService<IStartup>().DoWork(args);
        }


        public static void ConfigureAddEnvironmentVariable(IServiceCollection service)
        {

            var settingPath = Path.GetFullPath(Path.Combine(@"../../../"));
            var builder = new ConfigurationBuilder()
                .SetBasePath(settingPath)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .Build();
            service.AddOptions()
            .Configure<AppSetting>(builder.GetSection(nameof(AppSetting)));
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
