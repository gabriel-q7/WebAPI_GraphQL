using WebAPI_GraphQL_sln.src.BusinessRules.Requests;
using WebAPI_GraphQL_sln.src.BusinessRules.Responses;
using WebAPI_GraphQL_sln.src.BusinessRules.Validators;
using WebAPI_GraphQL_sln.src.Database.Domain;
using WebAPI_GraphQL_sln.src.Database.Repositories;

namespace WebAPI_GraphQL_sln.src.BusinessRules.Handlers
{
    public class UpsertTaskHandler : IUpsertTaskHandler
    {
        private readonly ITaskRepository _repository;

        private readonly ITaskValidator _validator;

        public UpsertTaskHandler(ITaskRepository repository, ITaskValidator validator)
        {
            _repository = repository;
            _validator = validator;
        }
        public UpsertTaskResponse Execute(UpsertTaskRequest request)
        {
            var validatorResult = _validator.Validate(request);
            if(!validatorResult.IsValid)
            {
                return new UpsertTaskResponse
                {
                    Errors = validatorResult.Errors
                };
            }

            ToDo entity;

            if (request.Id.HasValue)
            {
                entity = _repository.GetById(request.Id.Value);
                if (entity == null)
                    throw new Exception("Tarefa não encontrada");
            }
            else
            {
                entity = new ToDo();
            }

            entity.Title = request.Title;
            entity.Description = request.Description;
            entity.Done = request.Done;
            if (request.Done)
                entity.DtDone = DateTime.Now;
            else
                entity.DtDone = null;

            _repository.Save(entity);

            return new UpsertTaskResponse
            {
                Payload = new UpsertTaskResponsePayload
                {
                    Id = entity.Id.Value,
                    Title = entity.Title,
                    Description = entity.Description,
                    Done = entity.Done,
                    DtDone = entity.DtDone,
                }
            };

        }
    }
}