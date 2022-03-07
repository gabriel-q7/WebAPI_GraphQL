using WebAPI_GraphQL_sln.src.BusinessRules.Requests;
using WebAPI_GraphQL_sln.src.BusinessRules.Responses;

namespace WebAPI_GraphQL_sln.src.BusinessRules.Handlers
{
    public interface IGetByIdTaskHandler
    {
        TaskResponse Execute(GetByIdTaskRequest request);
    }
}