using Microsoft.EntityFrameworkCore;
using src.Database.Domain;

namespace src.Database
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions options) : base(options)
        {
            
        }   

        public DbSet<ToDo>? Tasks { get; set; }
    }
}
