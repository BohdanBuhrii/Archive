using Models.Abstract;


namespace Models.Concrete.Filters
{
    public class UserFilter : IModelFilter
    {
        public long? user_id;
        public string user_name;
        public string email;
        public string date_of_birth;
    }
}
