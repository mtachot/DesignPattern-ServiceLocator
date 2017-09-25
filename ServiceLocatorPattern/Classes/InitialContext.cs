using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLocatorPattern.Classes
{
    public class InitialContext
    {
        public object LookUp(string jndiName)
        {
            if (String.Compare(jndiName.ToUpper(), "SERVICE1") == 0)
            {
                Console.WriteLine("Looking up and creating a new Service1 object");
                return new Service1();
            }
            else if(String.Compare(jndiName.ToUpper(), "SERVICE2") == 0)
            {
                Console.WriteLine("Looking up and creating a new Service2 object");
                return new Service2();
            }
            return null;
        }
    }
}
