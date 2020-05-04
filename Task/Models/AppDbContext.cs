using Microsoft.EntityFrameworkCore;

namespace Task.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }
        
        public DbSet<MyTask> Tasks { get; set; }
        
    }
}