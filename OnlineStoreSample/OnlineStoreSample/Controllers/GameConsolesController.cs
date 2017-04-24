using OnlineStoreSample.Models;
using OnlineStoreSample.Models.SpecificItemModels;
using System.Web.Mvc;

namespace OnlineStoreSample.Controllers
{
    public class GameConsolesController : Controller
    {
        private ApplicationDbContext _context;

        public GameConsolesController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: GameConsoles
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult New()
        {
            GameConsole gameConsole = new GameConsole();

            return View("GameConsoleForm", gameConsole);
        }

        public ActionResult Save(GameConsole gameConsole)
        {
            if (!ModelState.IsValid)
                return View("GameConsoleForm", gameConsole);

            _context.Items.Add(gameConsole);
            _context.SaveChanges();

            return RedirectToAction("Index", "Home");
        }
    }
}