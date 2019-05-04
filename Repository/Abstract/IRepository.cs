using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Repository.Abstract
{
    public interface IRepository
    {
        bool Add(IInformable model);

        bool Delete(IInformable filter);

        bool Update(IInformable filter, IInformable model);

        List<object> Get(IInformable fillter);
        
    }
}
