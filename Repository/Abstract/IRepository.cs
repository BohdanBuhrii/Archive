using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Abstract
{
    public interface IRepository
    {
        bool Create();
        bool Read();
        bool Update();
        bool Delete();
    }
}
