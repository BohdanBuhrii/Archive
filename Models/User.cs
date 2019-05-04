using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository.Abstract;

namespace Models
{
    class User : IInformable
    {
        public long user_id;
        public string user_name;
        public string email;
        public string date_of_birth;

        public string[] GetFieldsName()
        {
            return new string[] {
                "user_id", "user_name", "email", "date_of_birth"};
        }

        public string[] GetFieldsValue() //проблема як визначати тип поля при записі в базу даних
        {
            return new string[] {
                user_id.ToString(), user_name, email, hash_password,
                is_employee.ToString(), access_level};
        }
    }
}

