using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Factory.Abstract;
using Repository.Abstract;

namespace Factory.Concrete
{
    public class TextFactory: IFactory
    {
        public IRepository GetRepository(string name)
        {
            if (name == "Users")
            {
                return new Repository.Concrete.Textbase.UsersRepo();
            }
            else if (name == "Documents")
            {
                return new Repository.Concrete.Textbase.DocumentsRepo();
            }
            else throw new Exception("No such repository with name " + name);
        }
    }
}
