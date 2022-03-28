using ToDoApi.src.BusinessRules.Responses;

namespace ToDoApi.src.BusinessRules.Handlers
{
    public interface IGetAllTasksHandler
    {
        TasksResponse Execute();
    }
}