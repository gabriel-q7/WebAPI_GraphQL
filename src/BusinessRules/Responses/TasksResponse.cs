using System.Collections.Generic;

namespace ToDoApi.src.BusinessRules.Responses
{
    public class TasksResponse
    {
        public List<TaskResponseItem> Payload { get; set; }
    }
}