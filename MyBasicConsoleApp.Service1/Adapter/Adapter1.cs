using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using MyBasicConsoleApp.Common.Model;
using MyBasicConsoleApp.Service1.Model;
using System;

namespace MyBasicConsoleApp.Service1.Adapter
{
    public class Adapter1 : IAdapter1
    {
        private readonly ILogger logger;
        private readonly IOptions<AppSetting> appSetting;

        public Adapter1(ILogger<Adapter1> _logger, IOptions<AppSetting> _appSetting)
        {
            logger = _logger;
            appSetting = _appSetting;
        }

        public Service1Model get()
        {
            Console.WriteLine(appSetting.Value.EnvVariable);
            logger.LogInformation("Some information has been logged !");
            return new Service1Model();
        }
    }
}
