using ServiceLocatorPattern.Classes;
using ServiceLocatorPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLocatorPattern
{
    class Program
    {
        public static void Main(string[] args)
        {
            IService service = ServiceLocator.GetService("Service1");
            service.Execute();
            service = ServiceLocator.GetService("Service2");
            service.Execute();

            Console.WriteLine("\n");

            service = ServiceLocator.GetService("Service1");
            service.Execute();
            service = ServiceLocator.GetService("Service2");
            service.Execute();

            Console.ReadLine();
        }
    }
}
