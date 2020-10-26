using Microsoft.Extensions.DependencyInjection;
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
            var serviceProvide = new ServiceCollection()
                .AddSingleton<IStartup, Startup>()
                .AddTransient<IAdapter1, Adapter1>()
                .AddTransient<IRepository1, Repository1>()
                .AddTransient<IApplication1, Application1>()
                .AddTransient<IUtility1, Utility1>()
                .BuildServiceProvider();

            serviceProvide.GetService<IStartup>().DoWork(args);
        }
    }
}
