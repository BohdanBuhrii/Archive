using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Factory.Abstract;
using Repository.Abstract;

namespace Factory.Concrete
{
    public class DBFactory : IFactory
    {
        
        public IRepository GetRepository(string name)
        {
            if (name == "users")
            {
                return new Repository.Concrete.Database.UsersRepo();
            }
            else if (name == "documents")
            {
                return new Repository.Concrete.Database.DocumentsRepo();
            }
            else if (name == "issuanceforms")
            {
                return new Repository.Concrete.Database.IssuanceFormsRepo();
            }
            else throw new Exception("No such repository with name " + name);
        }
    }
}
