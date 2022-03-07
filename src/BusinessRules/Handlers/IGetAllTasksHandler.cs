using WebAPI_GraphQL_sln.src.BusinessRules.Responses;

namespace WebAPI_GraphQL_sln.src.BusinessRules.Handlers
{
    public interface IGetAllTasksHandler
    {
        TasksResponse Execute();
    }
}