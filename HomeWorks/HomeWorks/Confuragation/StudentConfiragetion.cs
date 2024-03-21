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
    public class StudentConfiragetion : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasData(
                new Student
                {
                    StudentId = 1,
                     FirstName = "Test1",
                     LastName = "Test1",
                      Address = "Test1",
                       City = "Test1",
                        BirtDate = DateTime.Now,
                       
                },
                new Student
                {
                    StudentId = 2,
                    FirstName= "Test2",  
                     LastName = "Test2",
                     Address = "Test2",
                     City = "Test2",
                     BirtDate = DateTime.Now.AddDays(-1),
                   
                },
                new Student
                {
                    StudentId = 3,
                    FirstName = "Test3",
                    LastName = "Test3",
                    Address = "Test3",
                    City = "Test3",
                    BirtDate = DateTime.Now.AddMonths(-1),
                  
                },
                new Student
                {
                    StudentId  = 4,
                    FirstName = "Test4",
                    LastName = "Test4",
                    Address = "Test4",
                    City = "Test4",
                    BirtDate= DateTime.Now.AddMonths(-2),
                  
                });
        }
    }
}
