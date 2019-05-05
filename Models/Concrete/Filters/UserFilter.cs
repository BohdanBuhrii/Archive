using Models.Abstract;
using System;

namespace Models.Concrete.Filters
{
    public class UserFilter : IModelFilter
    {
        public long? user_id;
        public string user_name;
        public string email;
        public DateTime? date_of_birth;
    }
}
