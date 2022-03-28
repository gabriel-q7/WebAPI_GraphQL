using HotChocolate;
using ToDoApi.src.BusinessRules.Handlers;
using ToDoApi.src.BusinessRules.Requests;
using ToDoApi.src.BusinessRules.Responses;

namespace ToDoApi.src.Api
{
    public class Mutation
    {
        public UpsertTaskResponse UpsertTask([Service] IUpsertTaskHandler handler, UpsertTaskRequest request)
        {
            return handler.Execute(request);
        }
    }
}