using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Factory.Abstract;

namespace Factory.Concrete
{
    public static class FactoryProvider
    {
        static IFactory GetFactory(string factoryType)
        {
            if (factoryType == "DB") return new DBFactory();
            else if (factoryType == "File") return new TextFactory();
            else throw new Exception(string.Format("Factory \"{0}\" not exist",factoryType));
        }
    }
}
