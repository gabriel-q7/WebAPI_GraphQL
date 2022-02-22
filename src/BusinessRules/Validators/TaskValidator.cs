using FluentValidation;
using src.BusinessRules.Requests;

namespace src.BusinessRules.Validators
{
    public class TaskValidator : AbstractValidator<UpsertTaskRequest>,  ITaskValidator
    {
        public TaskValidator()
        {
            RuleFor(t => t.Title)
                .NotEmpty()
                .NotNull()
                .MinimumLength(3)
                .MaximumLength(20)
                .WithName("Título");

            RuleFor(t => t.Description)
                .NotEmpty()
                .NotNull()
                .MinimumLength(3)
                .MaximumLength(155)
                .WithName("Descrição");
        }
    }
}
