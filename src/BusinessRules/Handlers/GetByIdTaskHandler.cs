using WebAPI_GraphQL_sln.src.BusinessRules.Requests;
using WebAPI_GraphQL_sln.src.BusinessRules.Responses;
using WebAPI_GraphQL_sln.src.Database.Repositories;

namespace WebAPI_GraphQL_sln.src.BusinessRules.Handlers
{
    public class GetByIdTaskHandler : IGetByIdTaskHandler
    {
        private readonly ITaskRepository _repository;
        public GetByIdTaskHandler(ITaskRepository repository)
        {
            _repository = repository;
        }
        public TaskResponse Execute(GetByIdTaskRequest request)
        {
            var task = _repository.GetById(request.Id);
            if (task == null)
                throw new Exception("Tarefa não encontrada");
            
            return new TaskResponse
            {
                Payload = new TaskResponseItem
                {
                    Id = task.Id.Value,
                    Title = task.Title,
                    Description = task.Description,
                    Done = task.Done,
                    DtDone = task.DtDone,
                }
            };
        }
    }
}