using OnlineStoreSample.Models;
using OnlineStoreSample.Models.SpecificItemModels;
using System.Web.Mvc;

namespace OnlineStoreSample.Controllers
{
    public class CamerasController : Controller
    {
        private ApplicationDbContext _context;

        public CamerasController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: Camera
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult New()
        {
            Camera camera = new Camera();

            return View("CameraForm", camera);
        }

        public ActionResult Save(Camera camera)
        {
            if (!ModelState.IsValid)
                return View("CameraForm", camera);

            _context.Items.Add(camera);
            _context.SaveChanges();

            return RedirectToAction("Index", "Home");
        }
    }
}