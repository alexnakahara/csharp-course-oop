// See https://aka.ms/new-console-template for more information
using Linq.Models;

Console.WriteLine("Hello, World Linq!");


var students = new List<Student>()
{
    new Student(1, "Luis", "12345678910", 100),
    new Student(2, "Roberto", "98765432110", 35),
    new Student(3, "Bianca", "32165498701", 85),
    new Student(4, "Helena", "78945612301", 70),
    new Student(5, "Luis", "43265487699", 75),
};

var any = students.Any();
var any100  = students.Any(s => s.Grade == 100);

var single = students.Single(s => s.Id == 1);
var singleOrDefault = students.SingleOrDefault(s => s.Document == "98765432110");

var first = students.First(s => s.FullName == "Luis");
var firstOrDefault = students.FirstOrDefault(s => s.Grade == 0);

var orderedByGrade = students.OrderBy(s => s.Grade);
var orderedByGradeDescending = students.OrderByDescending(s => s.Grade);

var approvedStudents = students.Where(s => s.Grade >= 70);

var grades = students.Select(s => s.Grade);
var phoneNumbers = students.SelectMany(s => s.PhoneNumbers);


var sum = students.Sum(s => s.Grade);
var min = students.Min(s => s.Grade);
var max = students.Max(s => s.Grade);
var count = students.Count();


Console.ReadKey();


