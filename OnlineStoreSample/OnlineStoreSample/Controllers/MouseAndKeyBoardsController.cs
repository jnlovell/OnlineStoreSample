using OnlineStoreSample.Models;
using OnlineStoreSample.Models.SpecificItemModels;
using System.Web.Mvc;

namespace OnlineStoreSample.Controllers
{
    public class MouseAndKeyBoardsController : Controller
    {
        private ApplicationDbContext _context;

        public MouseAndKeyBoardsController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: MouseAndKeyBoards
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult New()
        {
            MouseAndKeyBoard mouseAndKeyBoard = new MouseAndKeyBoard();

            return View("MouseAndKeyBoardForm", mouseAndKeyBoard);
        }

        public ActionResult Save(MouseAndKeyBoard mouseAndKeyBoard)
        {
            if (!ModelState.IsValid)
                return View("MouseAndKeyBoardForm", mouseAndKeyBoard);

            _context.Items.Add(mouseAndKeyBoard);
            _context.SaveChanges();

            return RedirectToAction("Index", "Home");
        }
    }
}