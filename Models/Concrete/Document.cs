

using Models.Abstract;

namespace Models.Concrete
{
    public class Document : IModel
    {
        public long document_id;
        public long owner_id;
        public string type;
        public bool existence;

        public override string ToString()
        {
            return string.Format(
                "document_id: {0}\nowner_id: {1}\ntype: {2}\nexistence: {3}\n",
                document_id, owner_id, type, existence);
        }
    }
}
