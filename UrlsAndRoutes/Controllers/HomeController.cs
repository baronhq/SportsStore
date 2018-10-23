using System;
using System.Web.Mvc;

namespace UrlsAndRoutes.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            ViewBag.Controller = "Home";
            ViewBag.Action = "Index";
            return View("ActionName");
        }

        public ActionResult Index2()
        {
            ViewBag.Controller = "Home";
            ViewBag.Action = "Index2";
            return View("ActionName");
        }

        public ActionResult CustomVariable(string aaa, string ID = "Default")
        {
            ViewBag.Controller = "Home";
            ViewBag.Action = "CustomVariable";
            ViewBag.CustomVariable = ID ?? "no value";
            ViewBag.catchall = aaa;
            return View();
        }
    }
}
