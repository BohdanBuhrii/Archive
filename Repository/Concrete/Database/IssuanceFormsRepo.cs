using Models.Abstract;
using Models.Concrete;
using Models.Concrete.Filters;
using Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Common;

namespace Repository.Concrete.Database
{
    public class IssuanceFormsRepo : ConnectionManager, IRepository
    {
        public bool Add(IModel model)
        {
            try
            {
                IssuanceForm issuanceForm = (IssuanceForm)model;
                ExecuteNonQuery(string.Format(
                    "INSERT INTO issuanceforms (date_of_issue, document_id, user_id, was_returned) " +
                    "VALUES ('{0}',{1},{2},{3})",
                    issuanceForm.date_of_issue, issuanceForm.document_id, issuanceForm.user_id, issuanceForm.was_returned));
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
                IssuanceFormFilter issuanceFormFilter = (IssuanceFormFilter)filter;
                string query = "DELETE FROM issuanceforms WHERE ";
                bool optionAdded = false;

                if (issuanceFormFilter.date_of_issue.HasValue)
                {
                    query += "date_of_issue='" + issuanceFormFilter.date_of_issue + "'";
                    optionAdded = true;
                }
                if (issuanceFormFilter.document_id.HasValue)
                {
                    if (optionAdded) query += " and ";
                    query += "document_id=" + issuanceFormFilter.document_id;
                    optionAdded = true;
                }
                if (issuanceFormFilter.user_id.HasValue)
                {
                    if (optionAdded) query += " and ";
                    query += "user_id=" + issuanceFormFilter.user_id;
                    optionAdded = true;
                }
                if (issuanceFormFilter.was_returned.HasValue)
                {
                    if (optionAdded) query += " and ";
                    query += "was_returned=" + issuanceFormFilter.was_returned;
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
            try
            {
                IssuanceFormFilter issuanceFormFilter = (IssuanceFormFilter)filter;
                IssuanceFormFilter issuanceForm = (IssuanceFormFilter)model;
                string query = "UPDATE issuanceforms SET ";
                bool optionAdded = false;

                if (issuanceForm.date_of_issue.HasValue)
                {
                    query += "date_of_issue='" + issuanceForm.date_of_issue + "'";
                    optionAdded = true;
                }
                if (issuanceForm.document_id.HasValue)
                {
                    if (optionAdded) query += ", ";
                    query += "document_id=" + issuanceForm.document_id;
                    optionAdded = true;
                }
                if (issuanceForm.user_id.HasValue)
                {
                    if (optionAdded) query += ", ";
                    query += "user_id=" + issuanceForm.user_id;
                    optionAdded = true;
                }
                if (issuanceForm.was_returned.HasValue)
                {
                    if (optionAdded) query += ", ";
                    query += "was_returned=" + issuanceForm.was_returned;
                }

                query += " WHERE ";
                optionAdded = false;

                if (issuanceFormFilter.date_of_issue.HasValue)
                {
                    query += "date_of_issue='" + issuanceFormFilter.date_of_issue + "'";
                    optionAdded = true;
                }
                if (issuanceFormFilter.document_id.HasValue)
                {
                    if (optionAdded) query += " and ";
                    query += "document_id=" + issuanceFormFilter.document_id;
                    optionAdded = true;
                }
                if (issuanceFormFilter.user_id.HasValue)
                {
                    if (optionAdded) query += " and ";
                    query += "user_id=" + issuanceFormFilter.user_id;
                    optionAdded = true;
                }
                if (issuanceFormFilter.was_returned.HasValue)
                {
                    if (optionAdded) query += " and ";
                    query += "was_returned=" + issuanceFormFilter.was_returned;
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

            IssuanceFormFilter issuanceFormFilter = (IssuanceFormFilter)filter;
            string query = "SELECT * FROM issuanceforms WHERE ";
            bool optionAdded = false;

            if (issuanceFormFilter.date_of_issue.HasValue)
            {
                query += "date_of_issue='" + issuanceFormFilter.date_of_issue + "'";
                optionAdded = true;
            }
            if (issuanceFormFilter.document_id.HasValue)
            {
                if (optionAdded) query += " and ";
                query += "document_id=" + issuanceFormFilter.document_id;
                optionAdded = true;
            }
            if (issuanceFormFilter.user_id.HasValue)
            {
                if (optionAdded) query += " and ";
                query += "user_id=" + issuanceFormFilter.user_id;
                optionAdded = true;
            }
            if (issuanceFormFilter.was_returned.HasValue)
            {
                if (optionAdded) query += " and ";
                query += "was_returned=" + issuanceFormFilter.was_returned;
            }

            DbDataReader reader = ExecuteReader(query);

            while (reader.Read())
            {
                result.Add(new IssuanceForm
                {
                    date_of_issue = (DateTime)reader["date_of_issue"],
                    document_id = (long)reader["document_id"],
                    user_id = (long)reader["user_id"],
                    was_returned = (bool)reader["was_returned"]
                });
            }

            RefreshDataReader();

            return result;
        }

        public List<IModel> GetAll()
        {
            List<IModel> result = new List<IModel>();

           
            DbDataReader reader = ExecuteReader("SELECT * FROM issuanceforms");

            while (reader.Read())
            {
                result.Add(new IssuanceForm
                {
                    date_of_issue = (DateTime)reader["date_of_issue"],
                    document_id = (long)reader["document_id"],
                    user_id = (long)reader["user_id"],
                    was_returned = (bool)reader["was_returned"]
                });
            }

            RefreshDataReader();

            return result;
        }
    }
}
