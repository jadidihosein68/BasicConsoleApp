using Microsoft.Extensions.Logging;
using MyBasicConsoleApp.Service1.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyBasicConsoleApp.Service1.Adapter
{
    public class Adapter1 : IAdapter1
    {
        private readonly ILogger logger;
        public Adapter1(ILogger<Adapter1> _logger)
        {
            logger = _logger;
        }

        public Service1Model get()
        {
            return new Service1Model();
        }
    }


    public interface IAdapter1 {
        Service1Model get();
    }

}
