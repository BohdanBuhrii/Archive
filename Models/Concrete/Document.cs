﻿

using Models.Abstract;

namespace Models.Concrete
{
    public class Document : IModel
    {
        public long document_id;
        public long owner_id;
        public string type;
        //public string last_check_date;
        public bool existence;
    }
}
