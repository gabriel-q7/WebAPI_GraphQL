using System;
using System.Linq;
using WebAPI_GraphQL_sln.src.Database.Domain;
using WebAPI_GraphQL_sln.src.Database;

namespace WebAPI_GraphQL_sln.src.Database.Repositories
{
    public class TaskRepository : ITaskRepository
    {
        private readonly TodoContext _db;

        public TaskRepository(TodoContext db) => _db = db;
        
        public IQueryable<ToDo> GetAll()
        {
            return _db.Tasks.AsQueryable();
        }

        public ToDo GetById(Guid Id)
        {
            return _db.Tasks.SingleOrDefault(q => q.Id == Id);
        }

        public ToDo Save(ToDo entity)
        {
            if (!entity.Id.HasValue)
            {
                entity.Id = Guid.NewGuid();
                _db.Tasks.Add(entity);
            }

            _db.SaveChanges();

            return entity;
        }
    }
}
