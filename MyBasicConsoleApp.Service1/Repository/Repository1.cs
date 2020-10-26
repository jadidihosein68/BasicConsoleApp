using MyBasicConsoleApp.Service1.Adapter;
using MyBasicConsoleApp.Service1.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyBasicConsoleApp.Service1.Repository
{
    public class Repository1 : IRepository1
    {
        private readonly IAdapter1 adapter1;
        public Repository1(IAdapter1 _adapter1)
        {
            adapter1 = _adapter1;
        }
        public Service1Model Get()
        {
            return adapter1.get();
        }

    }

    public interface IRepository1 {
        Service1Model Get();
    }
}
