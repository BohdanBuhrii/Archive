using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Abstract;

namespace Models
{
    public class Document : IModel
    {
        public long document_id;
        public long owner_id;
        public string type;
        public string last_check_date;
        public bool existence;
    }
}
