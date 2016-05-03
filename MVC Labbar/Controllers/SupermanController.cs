using System.Web.Mvc;

namespace MVC_Labbar.Controllers
{
    public class SupermanController : Controller
    {
        // GET: Superman
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult DoGood()
        {
            return View();
        }
    }
}