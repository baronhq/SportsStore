using System.Web.Mvc;
using ControllerExtensibility.Models;

namespace ControllerExtensibility.Controllers
{
    public class CustomerController : Controller
    {

        public ViewResult Index()
        {
            return View("Result", new Result
            {
                ControllerName = "Customer",
                ActionName = "Index"
            });
        }

        [HttpGet]
        [ActionName("Enumerate")]
        public ViewResult List()
        {
            return View("Result", new Result
            {
                ControllerName = "Customer",
                ActionName = "List"
            });
        }

        [HttpPost]
        public ViewResult Enumerate()
        {
            return View("Result", new Result
            {
                ControllerName = "Customer",
                ActionName = "Enumerate"
            });
        }

        [NonAction]
        public ActionResult MyAction()
        {
            return View();
        }
    }
}
