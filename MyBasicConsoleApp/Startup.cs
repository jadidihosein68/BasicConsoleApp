using MyBasicConsoleApp.Service1.Application;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyBasicConsoleApp.Core
{
    public class Startup : IStartup
    {
        private readonly IApplication1 application1;

        public Startup(IApplication1 _application1)
        {
            application1 = _application1;
        }

        public void DoWork(string[] args)
        {
            application1.Perform();
            Console.ReadLine();
        }
    }
}
