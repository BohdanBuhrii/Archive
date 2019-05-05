
using Models.Abstract;
using System;

namespace Models.Concrete
{
    public class IssuanceForm : IModel
    {
        public DateTime date_of_issue;
        public long document_id;
        public long user_id;
        public bool was_returned;
    }
}
