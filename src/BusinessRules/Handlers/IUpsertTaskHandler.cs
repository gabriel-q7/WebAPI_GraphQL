using WebAPI_GraphQL_sln.src.BusinessRules.Requests;
using WebAPI_GraphQL_sln.src.BusinessRules.Responses;

namespace WebAPI_GraphQL_sln.src.BusinessRules.Handlers
{
    public interface IUpsertTaskHandler
    {
         UpsertTaskResponse Execute(UpsertTaskRequest request);
    }
}