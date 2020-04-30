using Microsoft.EntityFrameworkCore;
using TestARMMVC.Models;

namespace TestARMMVC.Data
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> options)
            : base(options)
        {
        }

        public DbSet<Student> Student { get; set; }
    
    }
}
