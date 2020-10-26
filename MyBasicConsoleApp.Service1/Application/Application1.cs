using MyBasicConsoleApp.Service1.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyBasicConsoleApp.Service1.Application
{
    public class Application1 : IApplication1
    {
        private readonly IRepository1 repository1;
        public Application1(IRepository1 _repository1)
        {
            repository1 = _repository1;
        }

        public void Perform() {
            var someValue = repository1.Get();
        }
    }

    public interface IApplication1 {
        void Perform();
    }
}
