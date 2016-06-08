using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab2.Models;

namespace Lab2.Controllers
{
    public class GamesController : Controller
    {
        // GET: Games
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult TwentyOne()
        {
            var twentyOne = new TwentyOne();
            this.Session["21"] = twentyOne;
            return View(twentyOne);
        }

        [HttpPost]
        public ActionResult TwentyOne(int? choice)
        {
            var twentyOne = (TwentyOne) this.Session["21"];
            if (choice != null) twentyOne.TheGame(choice.Value);
            return View(twentyOne);
        }
    }
}