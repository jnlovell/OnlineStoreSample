using OnlineStoreSample.Models;
using OnlineStoreSample.Models.SpecificItemModels;
using System.Web.Mvc;

namespace OnlineStoreSample.Controllers
{
    public class DesktopsController : Controller
    {
        private ApplicationDbContext _context;

        public DesktopsController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: DesktopItem
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult New()
        {
            Desktop desktop = new Desktop();

            return View("DesktopForm", desktop);
        }

        public ActionResult Save(Desktop desktop)
        {
            if (!ModelState.IsValid)
                return View("DesktopForm", desktop);

            _context.Items.Add(desktop);
            _context.SaveChanges();

            return RedirectToAction("Index", "Home");
        }
    }
}