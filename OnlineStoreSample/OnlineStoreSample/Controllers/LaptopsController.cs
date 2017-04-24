using OnlineStoreSample.Models;
using OnlineStoreSample.Models.SpecificItemModels;
using System.Web.Mvc;

namespace OnlineStoreSample.Controllers
{
    public class LaptopsController : Controller
    {
        private ApplicationDbContext _context;

        public LaptopsController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: Laptops
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult New()
        {
            Laptop laptop = new Laptop();

            return View("LaptopForm", laptop);
        }

        public ActionResult Save(Laptop laptop)
        {
            if (!ModelState.IsValid)
                return View("LaptopForm", laptop);

            _context.Items.Add(laptop);
            _context.SaveChanges();

            return RedirectToAction("Index", "Home");
        }
    }
}