using System;
using System.Linq;
using ToDoApi.src.Database.Domain;

namespace ToDoApi.src.Database.Repositories
{
    public interface ITaskRepository
    {
        IQueryable<ToDo> GetAll();

        ToDo GetById(Guid id);

        ToDo Save(ToDo entity);
    }
}
