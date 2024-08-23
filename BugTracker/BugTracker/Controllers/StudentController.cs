using BugTracker.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugTracker.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            List<Student> students = new List<Student>();

            Student s1 = new Student();
            Student s2, s3;


            s1.ContactNo = "1111";
            s1.Email = "s1@gmail.com";
            s1.FirstName = "Ram";
            s1.LastName = "Shrestha";

            s2 = new Student()
            {
                ContactNo = "2222",
                Email = "s2@gmail.com",
                FirstName = "Sita",
                LastName = "Rai"
            };

            s3 = new Student();

            s3.ContactNo = "3333";
            s3.FirstName = "Hari";
            s3.LastName = "Shrestha";
            s3.Email = "s3@gmail.com";

            students.Add(s1);
            students.Add(s2);
            students.Add(s3);


            return View(students);
        }
    }
}
