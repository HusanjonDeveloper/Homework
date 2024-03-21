using HomeWorks.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HomeWorks.Confuragation
{
    public class PassportConfuragation : IEntityTypeConfiguration<Passport>
    {
        public void Configure(EntityTypeBuilder<Passport> builder)
        {
            builder.HasData(
                new Passport
                {
                    PassportId = 1,
                    PersonId = 1,
                    FirstName = "Test1",
                    LastName = "Test1",
                    BirthDate = new DateTime(1980,2,3),
                    Series = "AC23214"
                },
                new Passport
                {
                    PassportId = 2,
                    PersonId = 2,
                    FirstName = "Test2",
                    LastName = "Test2",
                    BirthDate = new DateTime(1990,2,1),
                    Series = "AD234234"
                },
                new Passport
                {
                    PassportId = 3,
                    PersonId = 3,
                    FirstName = "Test3",
                    LastName = "Test3",
                    BirthDate = new DateTime(2001,3,1),
                    Series = "SA2423424"
                },
                new Passport
                {
                    PassportId = 4,
                    PersonId = 4,
                    FirstName = "Test4",
                    LastName = "Test4",
                    BirthDate = new DateTime(2005,1,2),
                    Series = "AD837874"
                });
        }
    }
}
