using HomeWorks.Context;
using HomeWorks.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;
using Microsoft.Extensions.DependencyInjection;

var context = new MyAppDbContext();
var students = new List<Student>();

var student = new Student
{
    StudentId = 1,
    FirstName = "Test",
    LastName = "Test",
    Address = "Test",
    BirtDate = DateTime.Now.AddDays(-1),
    City = "Test",
};

for (int i = 0; i < 10; i ++)
{
    students.Add(new Student
    {
        StudentId = i + 1,
        FirstName = $"Default2{i +1}",
        LastName = $"Default2{i +1}",
        Address = $"Default2{i + 1}",
        BirtDate = DateTime.Now.AddDays(-(i+1)),
        City = $"Default2{i + 1}",
    });
};

var people = context.People.SelectMany(o => o.Vehicles);
Console.WriteLine(people.ToQueryString());