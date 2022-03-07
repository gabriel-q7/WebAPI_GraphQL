using Microsoft.EntityFrameworkCore;
using WebAPI_GraphQL_sln.src.Database.Domain;

namespace WebAPI_GraphQL_sln.src.Database
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions options) : base(options)
        {}   

        public DbSet<ToDo> Tasks { get; set; }
    }
}
