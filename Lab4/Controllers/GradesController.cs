using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab4.Models;

namespace Lab4.Controllers
{
    public class GradesController : Controller
    {
        // GET: Grades
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult _GradesList(int id)
        {
            List<Grade> grades = ((Student) Session["Student"]).Grades;
            return PartialView(grades);
        }
        public PartialViewResult _Create(int id)
        {
            return PartialView();
        }
        [HttpPost]
        public ActionResult _Create(Grade model)
        {
            
            ((Student)Session["Student"]).Grades.Add(model);

            return RedirectToAction(actionName: "Details",controllerName:"Student", routeValues: new {id = 1});
        }
    }
}