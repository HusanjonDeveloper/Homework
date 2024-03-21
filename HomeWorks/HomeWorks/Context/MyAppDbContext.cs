using HomeWorks.Confuragation;
using HomeWorks.Models;
using Microsoft.EntityFrameworkCore;

namespace HomeWorks.Context
{
    public class MyAppDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public  DbSet<Person> People { get; set; }

        public MyAppDbContext()
        {
            //Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=LAPTOP-1FG38VDK;Database=ConsoleDb; Integrated Security=true;TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // one-to-one
            modelBuilder.Entity<Person>()
                 .HasOne(o => o.Passport)
                 .WithOne(p => p.Person)
                 .HasForeignKey<Passport>(x => x.PersonId);


            modelBuilder.ApplyConfiguration(new StudentConfiragetion());
            modelBuilder.ApplyConfiguration(new PassportConfuragation());
            modelBuilder.ApplyConfiguration(new PersonConfiragetion());

        }
    }
}
