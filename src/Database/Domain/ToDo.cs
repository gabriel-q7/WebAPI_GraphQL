using System;

namespace WebAPI_GraphQL_sln.src.Database.Domain
{
    public class ToDo
    {
        public Guid? Id {get; set;}

        public string? Title {get; set;}

        public string? Description {get; set;}

        public bool Done {get; set;}

        public DateTime? DtDone {get; set;}
    }
}
