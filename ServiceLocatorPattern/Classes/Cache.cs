using ServiceLocatorPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLocatorPattern.Classes
{
    public class Cache
    {
        private List<IService> services;

        public Cache()
        {
            services = new List<IService>();
        }

        public IService GetService(string serviceName)
        {
            foreach (IService service in services)
            {
                if (String.Compare(service.GetName().ToUpper(), serviceName.ToUpper()) == 0)
                {
                    Console.WriteLine(String.Format("Returning cached {0} object", serviceName));
                    return service;
                }
            }
            return null;
        }

        public void AddService(IService newService)
        {
            bool exists = false;

            foreach (IService service in services)
            {
                if (String.Compare(service.GetName().ToUpper(), newService.GetName().ToUpper()) == 0)
                    exists = true;
            }
            if (!exists)
                services.Add(newService);
        }
    }
}
