using ServiceLocatorPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLocatorPattern.Classes
{
    public class ServiceLocator
    {
        private static Cache cache = new Cache();

        public static IService GetService(string jndiName)
        {
            IService service = cache.GetService(jndiName);
            if (service != null)
                return service;

            InitialContext context = new InitialContext();
            IService service1 = (IService)context.LookUp(jndiName);
            cache.AddService(service1);
            return service1;
        }
    }
}
