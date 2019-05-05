

using Models.Abstract;

namespace Models.Concrete
{
    public class User : IModel
    {
        public long user_id;
        public string user_name;
        public string email;
        public string date_of_birth;
    }
}

