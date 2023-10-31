namespace Linq.Models
{
    public class Student
    {

        public Student(int id, string fullName, string document, int grade)
        {
            Id = id;
            FullName = fullName;
            Document = document;
            Grade = grade;
            PhoneNumbers = new List<string> { "12345678", "2385445454", "3030303030" };
        }

        public int Id { get; set; }
        public string FullName { get; set; }
        public string Document { get; set; }
        public int Grade { get; set; }
        public List<string> PhoneNumbers { get; set; }
    }

}
