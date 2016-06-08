using System.Collections.Generic;
using System.Web.Mvc;
using Lab2._2.Models;

namespace Lab2._2.Controllers
{
    public class GameController : Controller
    {
        // GET: Game
        public ActionResult Index()
        {
            var game = new GameTModel();
            this.Session["game"] = game;
            return View(game);
        }
        [HttpPost]
        public ActionResult Index(int? userInput)
        {

            var game = (GameTModel)this.Session["game"];

            List<string> IndexList = new List<string>();

            var list = (List<string>)this.Session["List"];
            if (list != null)
            {
                IndexList = list;
            }

            if (IndexList.IndexOf(userInput.ToString()) == -1)
            {

                if (userInput == null || game == null)
                {
                    return Index();
                }
                game.PlayLogic(userInput.Value);
                IndexList.Add(userInput.Value.ToString());
            }
            this.Session["List"] = IndexList;
            return View(game);
        }
    }
}