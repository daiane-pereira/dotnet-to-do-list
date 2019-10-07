using Microsoft.EntityFrameworkCore;
using ToDoList.Models;

namespace ToDoList.Configuration
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        
        public DbSet<Task> Task { get; set; }
    }
}