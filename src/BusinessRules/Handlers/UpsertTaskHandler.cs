using WebAPI_GraphQL_sln.src.BusinessRules.Requests;
using WebAPI_GraphQL_sln.src.BusinessRules.Responses;
using WebAPI_GraphQL_sln.src.BusinessRules.Validators;
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
            throw new NotImplementedException();
        }
    }
}