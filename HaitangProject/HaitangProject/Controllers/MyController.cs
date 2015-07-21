using System.Web.Mvc;

namespace HaitangProject.Controllers
{
    public class MyController : Controller
    {
        // GET: My
        public ActionResult Index()
        {
            ViewBag.Content = "你好2";
            return View();
        }

        public ActionResult Default()
        {
            return View("Index2");
        }
    }
}