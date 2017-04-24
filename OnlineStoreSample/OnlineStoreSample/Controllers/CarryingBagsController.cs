using OnlineStoreSample.Models;
using OnlineStoreSample.Models.SpecificItemModels;
using System.Web.Mvc;

namespace OnlineStoreSample.Controllers
{
    public class CarryingBagsController : Controller
    {
        private ApplicationDbContext _context;
        public CarryingBagsController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: CarryingBags
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult New()
        {
            CarryingBag carryingBag = new CarryingBag();

            return View("CarryingBagForm", carryingBag);
        }

        public ActionResult Save(CarryingBag carryingBag)
        {
            if (!ModelState.IsValid)
                return View("CarryingBagForm", carryingBag);

            _context.Items.Add(carryingBag);
            _context.SaveChanges();

            return RedirectToAction("Index", "Home");
        }
    }
}