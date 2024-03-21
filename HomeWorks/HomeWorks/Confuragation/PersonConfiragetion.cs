using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeWorks.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HomeWorks.Confuragation
{
    public class PersonConfiragetion : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.HasData(
                new Person
                {
                    PersonId = 1,
                     Age = 44,
                      Name = "Test1",
                },
                new Person
                {
                    PersonId = 2,
                    Age = 34,
                    Name = "Test"
                },
                new Person
                {
                    PersonId = 3,
                    Age =  23,
                    Name = "Test"
                },
                new Person
                {
                    PersonId = 4,
                    Age = 19 ,
                    Name = "Test"
                });
        }
    }
}
