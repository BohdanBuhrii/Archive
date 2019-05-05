using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Concrete;
using Models.Abstract;
using Repository.Abstract;

namespace Repository.Concrete.Database
{
    public class DocumentsRepo : ConnectionManager, IRepository
    {
        public bool Add(IModel model)
        {
            try
            {
                Document document = (Document)model;
                ExecuteNonQuery(string.Format(
                    "INSERT INTO documents (document_id, owner_id, type, existence) " +
                    "VALUES ({0},{1},'{2}',{3})",
                    document.document_id, document.owner_id, document.type, document.existence));
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public bool Delete(IModelFilter filter)
        {
            return true;
        }

        public bool Update(IModelFilter filter, IModelFilter model)
        {
            return true;
        }

        public List<IModel> Get(IModelFilter filter)
        {
            List<IModel> result = new List<IModel>();

            return result;
        }
    }
}
