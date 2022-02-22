using src.Database.Domain;

namespace src.Database.Repositories
{
    public interface ITaskRepository
    {
        IQueryable<ToDo> GetAll();

        ToDo GetById(Guid id);

        ToDo Save(ToDo entity);
    }
}
