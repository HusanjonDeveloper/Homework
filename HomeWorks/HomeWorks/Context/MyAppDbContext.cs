using HomeWorks.Confuragation;
using HomeWorks.Models;
using Microsoft.EntityFrameworkCore;

namespace HomeWorks.Context
{
    public class MyAppDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public  DbSet<Person> People { get; set; }
        public  DbSet<Passport> Passports { get; set; }
        public  DbSet<Vehicle> Vehicles { get; set; }
        public  DbSet<Course> Courses { get; set; }

        public MyAppDbContext()
        {
            Database.EnsureCreated();
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

            //one-to-many
            modelBuilder.Entity<Person>()
                .HasMany(p => p.Vehicles)
                .WithOne(o => o.Owner)
                .HasForeignKey(c => c.PersonId);
            //many-to-many
            modelBuilder.Entity<Student>()
                .HasMany(p => p.Courses)
                .WithMany(o => o.Students);

            modelBuilder.ApplyConfiguration(new StudentConfiragetion());
            modelBuilder.ApplyConfiguration(new PassportConfuragation());
            modelBuilder.ApplyConfiguration(new PersonConfiragetion());
            modelBuilder.ApplyConfiguration(new VehicleConfuragation());

        }
    }
}
