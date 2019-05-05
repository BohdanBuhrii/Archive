using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Concrete;
using Models.Abstract;
using Repository.Abstract;
using Models.Concrete.Filters;
using System.Data.Common;

namespace Repository.Concrete.Database
{
    public class UsersRepo : ConnectionManager, IRepository
    {
        public bool Add(IModel model)
        {
            try
            {
                User user = (User)model;
                ExecuteNonQuery(string.Format(
                    "INSERT INTO users ( user_id, user_name, email, date_of_birth) " +
                    "VALUES ({0},'{1}','{2}','{3}')",
                    user.user_id, user.user_name, user.email, user.date_of_birth));
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
                UserFilter userFilter = (UserFilter)filter;
                string query = "DELETE FROM users WHERE ";
                bool optionAdded = false;

                if (userFilter.user_id.HasValue)
                {
                    query += "user_id=" + userFilter.user_id;
                    optionAdded = true;
                }
                if (userFilter.user_name != null)
                {
                    if (optionAdded) query += " and ";
                    query += "user_name='" + userFilter.user_name + "'";
                    optionAdded = true;
                }
                if (userFilter.email != null)
                {
                    if (optionAdded) query += " and ";
                    query += "email='" + userFilter.email + "'";
                    optionAdded = true;
                }
                if (userFilter.date_of_birth.HasValue)
                {
                    if (optionAdded) query += " and ";
                    query += "date_of_birth='" + userFilter.date_of_birth + "'";
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
                UserFilter userFilter = (UserFilter)filter;
                UserFilter user = (UserFilter)model;
                string query = "UPDATE users SET ";
                bool optionAdded = false;

                if (user.user_id.HasValue)
                {
                    query += "user_id=" + user.user_id;
                    optionAdded = true;
                }
                if (user.user_name != null)
                {
                    if (optionAdded) query += ", ";
                    query += "user_name='" + user.user_name + "'";
                    optionAdded = true;
                }
                if (user.email != null)
                {
                    if (optionAdded) query += ", ";
                    query += "email='" + user.email + "'";
                    optionAdded = true;
                }
                if (user.date_of_birth.HasValue)
                {
                    if (optionAdded) query += ", ";
                    query += "date_of_birth='" + user.date_of_birth + "'";
                }

                query += " WHERE ";
                optionAdded = false;

                if (userFilter.user_id.HasValue)
                {
                    query += "user_id=" + userFilter.user_id;
                    optionAdded = true;
                }
                if (userFilter.user_name != null)
                {
                    if (optionAdded) query += " and ";
                    query += "user_name='" + userFilter.user_name + "'";
                    optionAdded = true;
                }
                if (userFilter.email != null)
                {
                    if (optionAdded) query += " and ";
                    query += "email='" + userFilter.email + "'";
                    optionAdded = true;
                }
                if (userFilter.date_of_birth.HasValue)
                {
                    if (optionAdded) query += " and ";
                    query += "date_of_birth='" + userFilter.date_of_birth + "'";
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

            UserFilter userFilter = (UserFilter)filter;
            string query = "SELECT * FROM users WHERE ";
            bool optionAdded = false;

            if (userFilter.user_id.HasValue)
            {
                query += "user_id=" + userFilter.user_id;
                optionAdded = true;
            }
            if (userFilter.user_name != null)
            {
                if (optionAdded) query += " and ";
                query += "user_name='" + userFilter.user_name + "'";
                optionAdded = true;
            }
            if (userFilter.email != null)
            {
                if (optionAdded) query += " and ";
                query += "email='" + userFilter.email + "'";
                optionAdded = true;
            }
            if (userFilter.date_of_birth.HasValue)
            {
                if (optionAdded) query += " and ";

                query += "date_of_birth='" + userFilter.date_of_birth + "'";
            }

            DbDataReader reader = ExecuteReader(query);

            while (reader.Read())
            {
                result.Add(new User
                {
                    user_id = (long)reader["user_id"],
                    user_name = (string)reader["user_name"],
                    email = (string)reader["email"],
                    date_of_birth = (DateTime)reader["date_of_birth"]
                });
            }

            RefreshDataReader();

            return result;
        }
    }
}
