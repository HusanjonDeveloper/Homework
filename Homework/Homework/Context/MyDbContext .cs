using Homework.Models;
using Microsoft.EntityFrameworkCore;

namespace Homework.Context
{


    public class MyDbContext : DbContext
    {
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=LAPTOP-1FG38VDK;Database=Napa; Integrated Security=true;TrustServerCertificate=True");
        }
    }
}

