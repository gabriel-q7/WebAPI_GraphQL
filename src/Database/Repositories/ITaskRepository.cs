using System;
using System.Linq;
using WebAPI_GraphQL_sln.src.Database.Domain;

namespace WebAPI_GraphQL_sln.src.Database.Repositories
{
    public interface ITaskRepository
    {
        IQueryable<ToDo> GetAll();

        ToDo GetById(Guid id);

        ToDo Save(ToDo entity);
    }
}
