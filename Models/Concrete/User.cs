

using Models.Abstract;
using System;

namespace Models.Concrete
{
    public class User : IModel
    {
        public long user_id;
        public string user_name;
        public string email;
        public DateTime date_of_birth;

        public override string ToString()
        {
            return string.Format(
                "user_id; {0}\nuser_name: {1}\nemail: {2}\ndate_of_birth: {3}\n",
                user_id, user_name, email, date_of_birth);
        }
    }
}

