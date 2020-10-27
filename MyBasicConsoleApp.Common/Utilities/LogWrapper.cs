using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyBasicConsoleApp.Common.Utilities
{
    public class LogWrapper<T> : ILogWrapper<T>
    {
        private readonly ILogger<T> logger;

        public LogWrapper(ILogger<T> _logger)
        {
            logger = _logger;
        }

        public void LogInformation(string message)
        {
            logger.LogInformation(message);
        }

        public void LogError(Exception e, string message)
        {
            logger.LogError(e, message);
        }

        public void LogError(string message, params object[] args)
        {
            logger.LogError(message, args);
        }

    }
}
