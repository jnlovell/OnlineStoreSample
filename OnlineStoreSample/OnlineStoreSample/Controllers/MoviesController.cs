using OnlineStoreSample.Models;
using OnlineStoreSample.Models.SpecificItemModels;
using System.Web.Mvc;

namespace OnlineStoreSample.Controllers
{
    public class MoviesController : Controller
    {
        private ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: Movies
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult New()
        {
            Movie movie = new Movie();

            return View("MovieForm", movie);
        }

        public ActionResult Save(Movie movie)
        {
            if (!ModelState.IsValid)
                return View("MovieForm", movie);

            _context.Items.Add(movie);
            _context.SaveChanges();

            return RedirectToAction("Index", "Home");
        }
    }
}