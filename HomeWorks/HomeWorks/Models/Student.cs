namespace HomeWorks.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirtDate { get; set; }
        public  string City { get; set; }
        public string Address { get; set; }
        public  List<Course> Courses { get; set; }
    }
}
