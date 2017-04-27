using OnlineStoreSample.Models;
using System.Web.Mvc;

namespace OnlineStoreSample.Controllers
{
    public class HomeController : Controller
    {


        public ActionResult Index()
        {
            if (User.IsInRole(UserRoles.CanManageItems))
            {
                return View("EmployeeIndex");
            }
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}