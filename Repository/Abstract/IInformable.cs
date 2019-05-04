using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Abstract
{
    public interface IInformable
    {
        string GetTableName();
        string[] GetFieldsValue();
        string[] GetFieldsName();
    }
}
