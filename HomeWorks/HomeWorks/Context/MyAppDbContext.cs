using HomeWorks.Models;
using Microsoft.EntityFrameworkCore;

namespace HomeWorks.Context
{
    public class MyAppDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=LAPTOP-1FG38VDK;Database=NapaDb; Integrated Security=true;TrustServerCertificate=True");
        }
    }
}
