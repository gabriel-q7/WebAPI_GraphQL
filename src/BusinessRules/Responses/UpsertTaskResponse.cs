using FluentValidation.Results;

namespace WebAPI_GraphQL_sln.src.BusinessRules.Responses
{
    public class UpsertTaskResponse
    {
        public UpsertTaskResponsePayload? Payload { get; set; }

        public List<ValidationFailure>? Errors { get; set; }
    }

    public class UpsertTaskResponsePayload
    {
        public Guid? Id { get; set; }

        public string? Title { get; set; }

        public string? Description { get; set; }

        public bool Done { get; set; }

        public DateTime? DtDone { get; set; }
    }
}
