using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLocatorPattern.Interfaces
{
    public interface IService
    {
        string GetName();
        void Execute();
    }
}
