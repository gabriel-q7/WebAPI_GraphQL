using FluentValidation.Results;

namespace src.BusinessRules.Responses
{
    public class UpsertTaskResponse
    {
        public UpsertTaskResponsePayload Payload { get; set; }

        public List<ValidationFailure> Errors { get; set; }
    }

    public class UpsertTaskResponsePayload
    {
        
    }
}
