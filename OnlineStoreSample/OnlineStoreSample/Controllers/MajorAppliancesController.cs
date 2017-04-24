using OnlineStoreSample.Models;
using OnlineStoreSample.Models.SpecificItemModels;
using System.Web.Mvc;

namespace OnlineStoreSample.Controllers
{
    public class MajorAppliancesController : Controller
    {
        private ApplicationDbContext _context;

        public MajorAppliancesController()
        {
            _context = new ApplicationDbContext();
        }

        // GET: MajorAppliances
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult New()
        {
            MajorAppliance majorAppliance = new MajorAppliance();

            return View("MajorApplianceForm", majorAppliance);
        }

        public ActionResult Save(MajorAppliance majorAppliance)
        {
            if (!ModelState.IsValid)
                return View("MajorApplianceForm", majorAppliance);

            _context.Items.Add(majorAppliance);
            _context.SaveChanges();

            return RedirectToAction("Index", "Home");
        }
    }
}