
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
        public override string ToString()
        {
            return string.Format(
                "date_of_issue: {0}\ndocument_id: {1}\nuser_id: {2}\nwas_returned: {3}\n",
                date_of_issue, document_id, user_id, was_returned);
        }
    }
}
