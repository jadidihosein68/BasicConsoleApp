using System;
using System.Collections.Generic;
using System.Text;

namespace MyBasicConsoleApp.Core
{
    public class Startup : IStartup
    {
        public Startup()
        {

        }

        public void DoWork(string[] args)
        {
            Console.Write("App work !");
            Console.ReadLine();
            // application initial logics come here.
        }
    }
}
