using OnlineStoreSample.Models;
using OnlineStoreSample.Models.SpecificItemModels;
using System.Linq;
using System.Web.Mvc;

namespace OnlineStoreSample.Controllers
{
    public class ItemsController : Controller
    {
        private ApplicationDbContext _context;

        public ItemsController()
        {
            _context = new ApplicationDbContext();
        }

        // GET: Items
        public ActionResult Index()
        {
            var itemList = _context.Items.Where(i => i.Id > 0);

            return View(itemList);
        }

        public ActionResult Detail(int Id)
        {
            var item = _context.Items.SingleOrDefault(i => i.Id == Id);


            if (item == null)
                return HttpNotFound();

            return View(item);
        }

        // GET: Items/New/Id
        //Called to decide which Form to return to the client.
        //We needed a custome route because if we used Id it would over write each Model ID
        [Route("Items/New/{typeId}")]
        public ActionResult New(string typeId)
        {
            if (typeId == "Default")
                return View("ItemForm");

            if (typeId == "Desktop")
            {
                Desktop desktop = new Desktop();
                return View("DesktopForm", desktop);
            }

            if (typeId == "Camera")
            {
                Camera camera = new Camera();
                return View("CameraForm", camera);
            }

            if (typeId == "CarryingBag")
            {
                CarryingBag carryingBag = new CarryingBag();
                return View("CarryingBagForm", carryingBag);
            }

            if (typeId == "GameConsole")
            {
                GameConsole gameConsole = new GameConsole();
                return View("GameConsoleForm", gameConsole);
            }

            if (typeId == "Laptop")
            {
                Laptop laptop = new Laptop();
                return View("LaptopForm", laptop);
            }

            if (typeId == "MajorAppliance")
            {
                MajorAppliance majorAppliance = new MajorAppliance();
                return View("MajorApplianceForm", majorAppliance);
            }

            if (typeId == "MouseAndKeyBoard")
            {
                MouseAndKeyBoard mouseAndKeyBoard = new MouseAndKeyBoard();
                return View("MouseAndKeyBoardForm", mouseAndKeyBoard);
            }

            if (typeId == "Movie")
            {
                Movie movie = new Movie();
                return View("MovieForm", movie);
            }

            if (typeId == "Software")
            {
                Software software = new Software();
                return View("SoftwareForm", software);
            }

            if (typeId == "VideoGame")
            {
                VideoGame videoGame = new VideoGame();
                return View("VideoGameForm", videoGame);
            }


            return View("ItemForm");
        }

        //Returns the DesktopForm
        [HttpPost]
        public ActionResult NewDesktop(Desktop desktop)
        {
            if (!ModelState.IsValid)
                return View("DesktopForm", desktop);

            _context.Items.Add(desktop);
            _context.SaveChanges();

            return View("ItemForm");
        }

        //Returns the CameraForm
        [HttpPost]
        public ActionResult NewCamera(Camera camera)
        {
            if (!ModelState.IsValid)
                return View("CameraForm", camera);

            _context.Items.Add(camera);
            _context.SaveChanges();

            return View("ItemForm");
        }

        //Returns the CarryingBagForm
        [HttpPost]
        public ActionResult NewCarryingBag(CarryingBag carryingBag)
        {
            if (!ModelState.IsValid)
                return View("CarryingBagForm", carryingBag);

            _context.Items.Add(carryingBag);
            _context.SaveChanges();

            return View("ItemForm");
        }

        //Returns the GameConsoleForm
        [HttpPost]
        public ActionResult NewGameConsole(GameConsole gameConsole)
        {
            if (!ModelState.IsValid)
                return View("GameConsoleForm", gameConsole);

            _context.Items.Add(gameConsole);
            _context.SaveChanges();

            return View("ItemForm");
        }

        //Returns the LaptopForm
        [HttpPost]
        public ActionResult NewLaptop(Laptop laptop)
        {
            if (!ModelState.IsValid)
                return View("LaptopForm", laptop);

            _context.Items.Add(laptop);
            _context.SaveChanges();

            return View("ItemForm");
        }

        //Returns the MajorApplianceForm
        [HttpPost]
        public ActionResult NewMajorAppliance(MajorAppliance majorAppliance)
        {
            if (!ModelState.IsValid)
                return View("MajorApplianceForm", majorAppliance);

            _context.Items.Add(majorAppliance);
            _context.SaveChanges();

            return View("ItemForm");
        }

        //Returns the MouseAndKeyBoardForm
        [HttpPost]
        public ActionResult NewMouseAndKeyBoard(MouseAndKeyBoard mouseAndKeyBoard)
        {
            if (!ModelState.IsValid)
                return View("MouseAndKeyBoardForm", mouseAndKeyBoard);

            _context.Items.Add(mouseAndKeyBoard);
            _context.SaveChanges();

            return View("ItemForm");
        }

        //Returns the MovieForm
        [HttpPost]
        public ActionResult NewMovie(Movie movie)
        {
            if (!ModelState.IsValid)
                return View("MovieForm", movie);

            _context.Items.Add(movie);
            _context.SaveChanges();

            return View("ItemForm");
        }

        //Returns the SoftwareForm
        [HttpPost]
        public ActionResult NewSoftware(Software software)
        {
            if (!ModelState.IsValid)
                return View("SoftwareForm", software);

            _context.Items.Add(software);
            _context.SaveChanges();

            return View("ItemForm");
        }

        //Returns the VideoGameForm
        [HttpPost]
        public ActionResult NewVideoGame(VideoGame videoGame)
        {
            if (!ModelState.IsValid)
                return View("VideoGameForm", videoGame);

            _context.Items.Add(videoGame);
            _context.SaveChanges();

            return View("ItemForm");
        }
    }
}