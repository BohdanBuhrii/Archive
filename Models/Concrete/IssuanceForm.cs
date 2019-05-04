using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Abstract;

namespace Models.Concrete
{
    public class IssuanceForm : IModel
    {
        public string date;
        public long document_id;
        public long user_id;
        public bool was_returned;
    }
}
