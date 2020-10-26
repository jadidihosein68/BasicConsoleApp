using System;
using System.Collections.Generic;
using System.Text;

namespace MyBasicConsoleApp.Core
{
    public interface IStartup
    {
        void DoWork(string[] args);
    }
}
