using Microsoft.EntityFrameworkCore;

namespace MyApp.DataBase
{
    public class MyDBContext : DbContext
    {
        public MyDBContext(DbContextOptions<MyDBContext> options) : base(options)
        {
           
        }

        public DbSet<Student> Students { get; set; }
    }
}
