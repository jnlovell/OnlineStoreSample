using OnlineStoreSample.Models;
using OnlineStoreSample.Models.SpecificItemModels;
using System.Web.Mvc;

namespace OnlineStoreSample.Controllers
{
    public class SoftwaresController : Controller
    {
        private ApplicationDbContext _context;

        public SoftwaresController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: Softwares
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult New()
        {
            Software software = new Software();

            return View("SoftwareForm", software);
        }

        public ActionResult Save(Software software)
        {
            if (!ModelState.IsValid)
                return View("SoftwareForm", software);

            _context.Items.Add(software);
            _context.SaveChanges();

            return RedirectToAction("Index", "Home");
        }
    }
}