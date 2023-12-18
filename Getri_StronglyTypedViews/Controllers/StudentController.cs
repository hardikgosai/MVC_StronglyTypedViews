using Getri_StronglyTypedViews.Models;
using Microsoft.AspNetCore.Mvc;

namespace Getri_StronglyTypedViews.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
           List<Student> list = new List<Student>();

            Student student1 = new Student();
            student1.StudentId = 1;
            student1.StudentName = "John";
            student1.StudentBranch = "CSE";
            student1.StudentSection = "A";
            student1.StudentGender = "Male";
            list.Add(student1);

            Student student2 = new Student();
            student2.StudentId = 2;
            student2.StudentName = "Smith";
            student2.StudentBranch = "ECE";
            student2.StudentSection = "B";
            student2.StudentGender = "Female";
            list.Add(student2);

            Student student3 = new Student();
            student3.StudentId = 3;
            student3.StudentName = "Mark";
            student3.StudentBranch = "EEE";
            student3.StudentSection = "C";
            student3.StudentGender = "Male";
            list.Add(student3);


            return View(list);
        }
    }
}
