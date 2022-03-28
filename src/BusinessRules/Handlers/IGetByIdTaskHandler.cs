using ToDoApi.src.BusinessRules.Requests;
using ToDoApi.src.BusinessRules.Responses;

namespace ToDoApi.src.BusinessRules.Handlers
{
    public interface IGetByIdTaskHandler
    {
        TaskResponse Execute(GetByIdTaskRequest request);
    }
}