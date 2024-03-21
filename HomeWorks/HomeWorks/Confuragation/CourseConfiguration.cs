using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using HomeWorks.Migrations;
using HomeWorks.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HomeWorks.Confuragation
{
    public class CourseConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.HasData(
                new Student
                {
                    StudentId = 1,
                    FirstName = "Test1",
                    LastName = "Test1",
                    Address = "Test1",
                    BirtDate = DateTime.Now.AddDays(-1),
                    City = "Test1",
                    Courses = new List<Course>
                    {
                       new Course
                       {
                            CourseId = 1,
                             CourseName = "Bio",
                              StartDate = DateTime.Now.AddMinutes(50),
                       },
                       new Course
                       {
                           CourseId  = 2,
                           CourseName = "Math",
                           StartDate = DateTime.Now.AddMinutes(-40),
                       },
                       new Course
                       {
                           CourseId = 3,
                           CourseName = "Test",
                           StartDate = DateTime.Now
                       }
                    }
                },
                new Student
                {
                    StudentId = 2,
                    FirstName = "Test2",
                    LastName = "Test2",
                    Address = "Test2",
                    BirtDate = DateTime.Now.AddDays(-2),
                    City = "Test2",
                    Courses = new List<Course>
                    {
                       new Course
                       {
                           CourseId = 4,
                            CourseName = "Math",
                             StartDate= DateTime.Now.AddMinutes(50),
                       },
                       new Course
                       {
                            CourseId = 5,
                            CourseName = "Bio",
                             StartDate = DateTime.Now.AddMinutes(-30)
                       }
                    }
                },
                new Student
                {
                    StudentId = 3,
                    FirstName = "Test3",
                    LastName = "Test3",
                    Address = "Test3",
                    BirtDate = DateTime.Now.AddDays(-2),
                    City = "Test3",
                    Courses = new List<Course>
                    {
                        new Course
                    {
                         CourseId = 5,
                          CourseName = "Fizika",
                           StartDate = DateTime.Now.AddMinutes(-90)
                    },
                        new Course
                        {
                            CourseId = 6,
                            CourseName = "Math",
                            StartDate = DateTime.Now.AddMinutes(-90)
                        }


                    }
                },
                new Student
                {
                    StudentId = 4,
                    FirstName = "Test4",
                    LastName = "Test4",
                    Address = "Test4",
                    BirtDate = DateTime.Now.AddDays(-2),
                    City = "Test4",
                    Courses = new List<Course>
                    {
                        new Course
                    {
                         CourseId = 7,
                          CourseName = "Fizika",
                           StartDate = DateTime.Now.AddMinutes(-90)
                    },
                        new Course
                        {
                            CourseId = 8,
                            CourseName = "Math",
                            StartDate = DateTime.Now.AddMinutes(-90)
                        }


                    }
                });
        }
    }
}
