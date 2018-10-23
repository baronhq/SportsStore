using System.Web.Mvc;

namespace UrlsAndRoutes.AdditionalControllers2
{
    public class HomeController : Controller
    {

        public ActionResult Index2()
        {
            ViewBag.Controller = "Additional Controllers2 - Home";
            ViewBag.Action = "Index2";
            return View("ActionName");
        }
    }
}