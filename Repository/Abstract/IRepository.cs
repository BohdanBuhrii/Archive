using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Abstract;

namespace Repository.Abstract
{
    public interface IRepository
    {
        bool Add(IModel model);

        bool Delete(IModelFilter filter);

        bool Update(IModelFilter filter, IModel model);

        List<object> Get(IModel fillter);
        
    }
}
