using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Abstract;
using Models.Concrete;
using Repository.Abstract;

namespace Repository.Concrete.Textbase
{
    public class UsersRepo : IRepository
    {
        public bool Add(IModel model)
        {
            return true;
        }

        public bool Delete(IModelFilter filter)
        {
            return true;
        }

        public bool Update(IModelFilter filter, IModelFilter model)
        {
            return true;
        }

        public List<IModel> Get(IModelFilter filter)
        {
            List<IModel> result = new List<IModel>();

            return result;
        }

        public List<IModel> GetAll()
        {
            List<IModel> result = new List<IModel>();

            return result;
        }
    }
}
