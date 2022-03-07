using WebAPI_GraphQL_sln.src.BusinessRules.Handlers;
using WebAPI_GraphQL_sln.src.BusinessRules.Requests;
using WebAPI_GraphQL_sln.src.BusinessRules.Responses;

namespace WebAPI_GraphQL_sln.src.Api
{
    public class Mutation
    {
        public UpsertTaskResponse UpsertTask([Service] IUpsertTaskHandler handler, UpsertTaskRequest request)
        {
            return handler.Execute(request);
        }
    }
}