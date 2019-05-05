using System;
using System.Collections.Generic;
using Models.Concrete;
using Models.Abstract;
using Repository.Abstract;
using Models.Concrete.Filters;
using System.Data.Common;

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
            try
            {
                DocumentFilter documentFilter = (DocumentFilter)filter;
                string query = "DELETE FROM documents WHERE ";
                bool optionAdded = false;

                if (documentFilter.document_id.HasValue)
                {
                    query += "document_id=" + documentFilter.document_id;
                    optionAdded = true;
                }
                if (documentFilter.owner_id.HasValue)
                {
                    if (optionAdded) query += " and ";
                    query += "owner_id=" + documentFilter.owner_id;
                    optionAdded = true;
                }
                if (documentFilter.type != null)
                {
                    if (optionAdded) query += " and ";
                    query += "type='" + documentFilter.type + "'";
                    optionAdded = true;
                }
                if (documentFilter.existence.HasValue)
                {
                    if (optionAdded) query += " and ";
                    query += "existence=" + documentFilter.existence;
                }

                ExecuteNonQuery(query);
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        public bool Update(IModelFilter filter, IModelFilter model)
        {
            //"UPDATE tariffs SET subscription_fee = {0} WHERE kind_of_services='{1}'"
            try
            {
                DocumentFilter documentFilter = (DocumentFilter)filter;
                DocumentFilter document = (DocumentFilter)model;
                string query = "UPDATE documents SET ";
                bool optionAdded = false;


                if (document.document_id.HasValue)
                {
                    query += "document_id=" + document.document_id;
                    optionAdded = true;
                }
                if (document.owner_id.HasValue)
                {
                    if (optionAdded) query += ", ";
                    query += "owner_id=" + document.owner_id;
                    optionAdded = true;
                }
                if (document.type != null)
                {
                    if (optionAdded) query += ", ";
                    query += "type='" + document.type + "'";
                    optionAdded = true;
                }
                if (document.existence.HasValue)
                {
                    if (optionAdded) query += ", ";
                    query += "existence=" + document.existence;
                }

                query += " WHERE ";
                optionAdded = false;

                if (documentFilter.document_id.HasValue)
                {
                    query += "document_id=" + documentFilter.document_id;
                    optionAdded = true;
                }
                if (documentFilter.owner_id.HasValue)
                {
                    if (optionAdded) query += " and ";
                    query += "owner_id=" + documentFilter.owner_id;
                    optionAdded = true;
                }
                if (documentFilter.type != null)
                {
                    if (optionAdded) query += " and ";
                    query += "type='" + documentFilter.type + "'";
                    optionAdded = true;
                }
                if (documentFilter.existence.HasValue)
                {
                    if (optionAdded) query += " and ";
                    query += "existence=" + documentFilter.existence;
                }

                ExecuteNonQuery(query);
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        public List<IModel> Get(IModelFilter filter)
        {
            List<IModel> result = new List<IModel>();



            DocumentFilter documentFilter = (DocumentFilter)filter;
            string query = "SELECT * FROM documents WHERE ";
            bool optionAdded = false;

            if (documentFilter.document_id.HasValue)
            {
                query += "document_id=" + documentFilter.document_id;
                optionAdded = true;
            }
            if (documentFilter.owner_id.HasValue)
            {
                if (optionAdded) query += " and ";
                query += "owner_id=" + documentFilter.owner_id;
                optionAdded = true;
            }
            if (documentFilter.type != null)
            {
                if (optionAdded) query += " and ";
                query += "type='" + documentFilter.type + "'";
                optionAdded = true;
            }
            if (documentFilter.existence.HasValue)
            {
                if (optionAdded) query += " and ";
                query += "existence=" + documentFilter.existence;
            }

            DbDataReader reader = ExecuteReader(query);

            while (reader.Read())
            {
                result.Add(new Document
                {
                    document_id = (long)reader["document_id"],
                    owner_id = (long)reader["owner_id"],
                    existence = (bool)reader["existence"],
                    type = (string)reader["type"]
                });
            }


            RefreshDataReader();
            
            return result;
        }
    }
}
