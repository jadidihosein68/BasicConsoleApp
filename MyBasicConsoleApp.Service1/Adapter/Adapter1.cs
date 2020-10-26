using MyBasicConsoleApp.Service1.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyBasicConsoleApp.Service1.Adapter
{
    public class Adapter1 : IAdapter1
    {
        public Service1Model get()
        {
            return new Service1Model();
        }
    }


    public interface IAdapter1 {
        Service1Model get();
    }

}
