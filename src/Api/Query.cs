using WebAPI_GraphQL_sln.src.Database.Domain;

namespace WebAPI_GraphQL_sln.src.Api
{
    public class Query
    {
        public ToDo Task()
        {
            return new ToDo();
        }
    }
}