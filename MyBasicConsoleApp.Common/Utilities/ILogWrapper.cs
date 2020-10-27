using System;
using System.Collections.Generic;
using System.Text;

namespace MyBasicConsoleApp.Common.Utilities
{
    public interface ILogWrapper<T>
    {
        void LogInformation(string message);
        void LogError(Exception e, string message);
        void LogError(string message, params object[] args);
    }
}
