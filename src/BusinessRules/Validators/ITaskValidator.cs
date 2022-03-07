using FluentValidation;
using WebAPI_GraphQL_sln.src.BusinessRules.Requests;

namespace WebAPI_GraphQL_sln.src.BusinessRules.Validators
{
    public interface ITaskValidator : IValidator<UpsertTaskRequest>
    {
         
    }
}
