
using Models.Abstract;

namespace Models.Concrete
{
    public class IssuanceForm : IModel
    {
        public string date_of_issue;
        public long document_id;
        public long user_id;
        public bool was_returned;
    }
}
