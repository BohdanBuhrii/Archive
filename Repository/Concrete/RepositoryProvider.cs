using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository.Abstract;

namespace Repository.Concrete
{
    static class RepositoryProvider
    {
        static IRepository GetFactory(string factoryType)
        {
            if (factoryType == "DB") return new DBRepository();
            else if (factoryType == "File") return new FileRepository();
            else throw new Exception(string.Format("Factory \"{0}\" not exist", factoryType));
        }
    }
}
