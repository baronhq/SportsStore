using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControllersAndActions.Controllers
{
    public class ExampleController : Controller
    {
        // GET: Example
        public ViewResult Index()
        {
            //ViewBag.Message =TempData["Message"];
            //ViewBag.Date = TempData["Date"];

            DateTime dt = DateTime.Now;
            return View(dt);
        }

        //public RedirectResult Redirect()
        //{
        //    return RedirectPermanent("/Example/Index");
        //}

        public RedirectToRouteResult RedirectToRoute()
        {
            //return RedirectToRoute(new
            //{
            //    controller = "Example",
            //    action = "Index",
            //    ID = "MyID"
            //});
            TempData["Message"] = "hello1111";
            TempData["Date"] = DateTime.Now;

            DateTime dt = (DateTime)TempData.Peek("Date");
            TempData.Keep("Date");
            return RedirectToAction("index");
        }

        public HttpStatusCodeResult StatusCode()
        {
            return new HttpUnauthorizedResult();
        }
    }
}