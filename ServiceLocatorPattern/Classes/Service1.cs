using ServiceLocatorPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLocatorPattern.Classes
{
    public class Service1 : IService
    {
        public string GetName()
        {
            return "Service1";
        }

        public void Execute()
        {
            Console.WriteLine("Executing Service1");
        }
    }
}
