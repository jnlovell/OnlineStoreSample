using OnlineStoreSample.Models;
using OnlineStoreSample.Models.SpecificItemModels;
using System.Web.Mvc;

namespace OnlineStoreSample.Controllers
{
    public class VideoGamesController : Controller
    {
        private ApplicationDbContext _context;

        public VideoGamesController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: VideoGames
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult New()
        {
            VideoGame videoGame = new VideoGame();

            return View("VideoGameForm", videoGame);
        }

        public ActionResult Save(VideoGame videoGame)
        {
            if (!ModelState.IsValid)
                return View("VideoGameForm", videoGame);

            _context.Items.Add(videoGame);
            _context.SaveChanges();

            return RedirectToAction("Index", "Home");
        }
    }
}