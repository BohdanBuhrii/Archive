using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Factory.Abstract;
using Repository.Abstract;

namespace Factory.Concrete
{
    class DBFactory : IFactory
    {
        
        public IRepository GetRepository(string name)
        {
            if (name == "Users")
            { }
            else if (name == "Documents")
            { }
            else throw new Exception("No such repository with name ");
        }
    }
    }
}
