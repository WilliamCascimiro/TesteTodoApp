using Microsoft.EntityFrameworkCore;
using TodoApp.Models;

namespace TodoApp.Data
{
    public class  TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options) : base(options)
        {

        }
        
        public DbSet<TodoItem> TodoItems {get; set;}

    }
}