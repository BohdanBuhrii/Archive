using Models.Abstract;

namespace Models.Concrete.Filters
{
    public class IssuanceFormFilter : IModelFilter
    {
        public string date_of_issue;
        public long? document_id;
        public long? user_id;
        public bool? was_returned;
    }
}
