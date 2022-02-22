using FluentValidation;
using src.BusinessRules.Requests;

namespace src.BusinessRules.Validators
{
    public interface ITaskValidator : IValidator<UpsertTaskRequest>
    {
         
    }
}
