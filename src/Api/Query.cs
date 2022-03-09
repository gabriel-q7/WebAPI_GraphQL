using WebAPI_GraphQL_sln.src.BusinessRules.Handlers;
using WebAPI_GraphQL_sln.src.BusinessRules.Requests;
using WebAPI_GraphQL_sln.src.BusinessRules.Responses;

namespace WebAPI_GraphQL_sln.src.Api
{
    public class Query
    {
        public TasksResponse GetTasks([Service] IGetAllTasksHandler handler)
        {
            return handler.Execute();
        }

        public TaskResponse GetTask([Service] IGetByIdTaskHandler handler, GetByIdTaskRequest request)
        {
            return handler.Execute(request);
        }
    }
}