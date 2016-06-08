using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab4.Models;

namespace Lab4.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            Student student;
            if (Session["Student"] == null)
            {
                 student = new Student()
                {
                    StudentID = 1,
                    Name = "Kalle",
                    LastName = "Anka",
                    Adress = "Ankeborg 11",
                    Personnumber = "2453453",
                    Grades = new List<Grade>()
                    {
                        new Grade() {GradeID=1, Grad = "A", Subject = "Svenska"},
                        new Grade() {GradeID=2,Grad = "B", Subject = "Franska"}

                    }

                };
                Session["Student"] = student;
            }
            else
                student = (Student)Session["Student"];
            
            return View(student);
        }

        public ActionResult Details()
        {
            Student student;
            if (Session["Student"] == null)
            {
                student = new Student()
                {
                    StudentID = 1,
                    Name = "Kalle",
                    LastName = "Anka",
                    Adress = "Ankeborg 11",
                    Personnumber = "2453453",
                    Grades = new List<Grade>()
                    {
                        new Grade() {GradeID=1, Grad = "A", Subject = "Svenska"},
                        new Grade() {GradeID=2,Grad = "B", Subject = "Franska"}

                    }

                };
                Session["Student"] = student;
            }
            else
                student = (Student)Session["Student"];

            return View(student);
        }
    }
}