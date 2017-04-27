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
        [Authorize(Roles = UserRoles.CanManageItems)]
        public ActionResult Index()
        {
            var itemList = _context.Items.ToList();

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
        [Authorize(Roles = UserRoles.CanManageItems)]
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

        [Authorize(Roles = UserRoles.CanManageItems)]
        [Route("Items/Delete/{ItemId}")]
        public ActionResult Delete(int ItemId)
        {
            var itemToDelete = _context.Items.Single(m => m.Id == ItemId);

            if (itemToDelete == null)
                return HttpNotFound();

            _context.Items.Remove(itemToDelete);
            _context.SaveChanges();

            return RedirectToAction("Index", "Items");
        }


        //Takes in the itemType and the itemId to return it to a view
        [Authorize(Roles = UserRoles.CanManageItems)]
        [Route("Items/Edit/{typeId}/{itemId}")]
        public ActionResult Edit(string typeId, int itemId)
        {
            if (typeId == "Default")
                return View("ItemForm");

            if (typeId == "Desktop")
            {
                var desktop = _context.Items.OfType<Desktop>().Single(m => m.Id == itemId);
                if (desktop == null)
                    return HttpNotFound();

                return View("DesktopForm", desktop);
            }

            if (typeId == "Camera")
            {
                var camera = _context.Items.OfType<Camera>().Single(m => m.Id == itemId);
                if (camera == null)
                    return HttpNotFound();

                return View("CameraForm", camera);
            }

            if (typeId == "CarryingBag")
            {
                var carryingBag = _context.Items.OfType<CarryingBag>().Single(m => m.Id == itemId);
                if (carryingBag == null)
                    return HttpNotFound();

                return View("CarryingBagForm", carryingBag);
            }

            if (typeId == "GameConsole")
            {
                var gameConsole = _context.Items.OfType<GameConsole>().Single(m => m.Id == itemId);
                if (gameConsole == null)
                    return HttpNotFound();

                return View("GameConsoleForm", gameConsole);
            }

            if (typeId == "Laptop")
            {
                var laptop = _context.Items.OfType<Laptop>().Single(m => m.Id == itemId);
                if (laptop == null)
                    return HttpNotFound();

                return View("LaptopForm", laptop);
            }

            if (typeId == "MajorAppliance")
            {
                var majorAppliance = _context.Items.OfType<MajorAppliance>().Single(m => m.Id == itemId);
                if (majorAppliance == null)
                    return HttpNotFound();

                return View("MajorApplianceForm", majorAppliance);
            }

            if (typeId == "MouseAndKeyBoard")
            {
                var mouseAndKeyBoard = _context.Items.OfType<MouseAndKeyBoard>().Single(m => m.Id == itemId);
                if (mouseAndKeyBoard == null)
                    return HttpNotFound();

                return View("MouseAndKeyBoardForm", mouseAndKeyBoard);
            }

            if (typeId == "Movie")
            {
                var movie = _context.Items.OfType<Movie>().Single(m => m.Id == itemId);
                if (movie == null)
                    return HttpNotFound();

                return View("MovieForm", movie);
            }

            if (typeId == "Software")
            {
                var software = _context.Items.OfType<Software>().Single(m => m.Id == itemId);
                if (software == null)
                    return HttpNotFound();

                return View("SoftwareForm", software);
            }

            if (typeId == "VideoGame")
            {
                var videoGame = _context.Items.OfType<VideoGame>().Single(m => m.Id == itemId);
                if (videoGame == null)
                    return HttpNotFound();

                return View("VideoGameForm", videoGame);
            }


            return View("ItemForm");
        }



        //Returns the DesktopForm
        [HttpPost]
        [Authorize(Roles = UserRoles.CanManageItems)]
        public ActionResult NewDesktop(Desktop desktop)
        {
            if (!ModelState.IsValid)
                return View("DesktopForm", desktop);

            if (desktop.Id == 0)
            {
                _context.Items.Add(desktop);
            }
            else
            {
                var desktopInDb = _context.Items.OfType<Desktop>().Single(m => m.Id == desktop.Id);

                desktopInDb.Name = desktop.Name;
                desktopInDb.Model = desktop.Model;
                desktopInDb.Price = desktop.Price;
                desktopInDb.SKU = desktop.SKU;
                desktopInDb.Warranty = desktop.Warranty;
                desktopInDb.Company = desktop.Company;
                desktopInDb.DesktopOperatingSystem = desktop.DesktopOperatingSystem;
                desktopInDb.DesktopProcessor = desktop.DesktopProcessor;
                desktopInDb.DesktopRAM = desktop.DesktopRAM;
                desktopInDb.DesktopStorageSize = desktop.DesktopStorageSize;
                desktopInDb.DesktopStorageType = desktop.DesktopStorageType;
                desktopInDb.ElectronicSpecifications = desktop.ElectronicSpecifications;
            }
            _context.SaveChanges();

            return View("ItemForm");
        }

        //Returns the CameraForm
        [HttpPost]
        [Authorize(Roles = UserRoles.CanManageItems)]
        public ActionResult NewCamera(Camera camera)
        {
            if (!ModelState.IsValid)
                return View("CameraForm", camera);

            if (camera.Id == 0)
            {
                _context.Items.Add(camera);
            }
            else
            {
                var cameraInDb = _context.Items.OfType<Camera>().Single(m => m.Id == camera.Id);

                cameraInDb.Name = camera.Name;
                cameraInDb.Model = camera.Model;
                cameraInDb.Price = camera.Price;
                cameraInDb.SKU = camera.SKU;
                cameraInDb.Company = camera.Company;
                cameraInDb.Warranty = camera.Warranty;
                cameraInDb.ElectronicSpecifications = camera.ElectronicSpecifications;
                cameraInDb.CameraFPS = camera.CameraFPS;
                cameraInDb.CameraResolution = camera.CameraResolution;
                cameraInDb.CameraType = camera.CameraType;
            }

            _context.SaveChanges();

            return View("ItemForm");
        }

        //Returns the CarryingBagForm
        [HttpPost]
        [Authorize(Roles = UserRoles.CanManageItems)]
        public ActionResult NewCarryingBag(CarryingBag carryingBag)
        {
            if (!ModelState.IsValid)
                return View("CarryingBagForm", carryingBag);

            if (carryingBag.Id == 0)
            {
                _context.Items.Add(carryingBag);
            }
            else
            {
                var carryingBagInDb = _context.Items.OfType<CarryingBag>().Single(m => m.Id == carryingBag.Id);

                carryingBagInDb.Name = carryingBag.Name;
                carryingBagInDb.Price = carryingBag.Price;
                carryingBagInDb.SKU = carryingBag.SKU;
                carryingBagInDb.Warranty = carryingBag.Warranty;
                carryingBagInDb.Model = carryingBag.Model;
                carryingBagInDb.Company = carryingBag.Company;
                carryingBagInDb.AccessoryDescription = carryingBag.AccessoryDescription;
                carryingBagInDb.BagColor = carryingBag.BagColor;
                carryingBagInDb.BagSize = carryingBag.BagSize;
                carryingBagInDb.BagType = carryingBag.BagType;
            }

            _context.SaveChanges();

            return View("ItemForm");
        }

        //Returns the GameConsoleForm
        [HttpPost]
        [Authorize(Roles = UserRoles.CanManageItems)]
        public ActionResult NewGameConsole(GameConsole gameConsole)
        {
            if (!ModelState.IsValid)
                return View("GameConsoleForm", gameConsole);

            if (gameConsole.Id == 0)
            {
                _context.Items.Add(gameConsole);
            }
            else
            {
                var gameConsoleInDb = _context.Items.OfType<GameConsole>().Single(m => m.Id == gameConsole.Id);

                gameConsoleInDb.Name = gameConsole.Name;
                gameConsoleInDb.Model = gameConsole.Model;
                gameConsoleInDb.Price = gameConsole.Price;
                gameConsoleInDb.SKU = gameConsole.SKU;
                gameConsoleInDb.Warranty = gameConsole.Warranty;
                gameConsoleInDb.Company = gameConsole.Company;
                gameConsoleInDb.ElectronicSpecifications = gameConsole.ElectronicSpecifications;
                gameConsoleInDb.GameConsoleColor = gameConsole.GameConsoleColor;
                gameConsoleInDb.GameConsoleStorage = gameConsole.GameConsoleStorage;
            }
            _context.SaveChanges();

            return View("ItemForm");
        }

        //Returns the LaptopForm
        [HttpPost]
        [Authorize(Roles = UserRoles.CanManageItems)]
        public ActionResult NewLaptop(Laptop laptop)
        {
            if (!ModelState.IsValid)
                return View("LaptopForm", laptop);

            if (laptop.Id == 0)
            {
                _context.Items.Add(laptop);
            }
            else
            {
                var laptopInDb = _context.Items.OfType<Laptop>().Single(m => m.Id == laptop.Id);

                laptopInDb.Name = laptopInDb.Name;
                laptopInDb.Model = laptopInDb.Model;
                laptopInDb.Price = laptop.Price;
                laptopInDb.SKU = laptop.SKU;
                laptopInDb.Warranty = laptop.Warranty;
                laptopInDb.Company = laptop.Company;
                laptopInDb.ElectronicSpecifications = laptop.ElectronicSpecifications;
                laptopInDb.LaptopOperatingSystem = laptop.LaptopOperatingSystem;
                laptopInDb.LaptopProcessor = laptop.LaptopProcessor;
                laptopInDb.LaptopRAM = laptop.LaptopRAM;
                laptopInDb.LaptopScreenSize = laptop.LaptopScreenSize;
                laptopInDb.LaptopStorageSize = laptop.LaptopStorageSize;
                laptopInDb.LaptopStorageType = laptop.LaptopStorageType;
            }
            _context.SaveChanges();

            return View("ItemForm");
        }

        //Returns the MajorApplianceForm
        [HttpPost]
        [Authorize(Roles = UserRoles.CanManageItems)]
        public ActionResult NewMajorAppliance(MajorAppliance majorAppliance)
        {
            if (!ModelState.IsValid)
                return View("MajorApplianceForm", majorAppliance);

            if (majorAppliance.Id == 0)
            {
                _context.Items.Add(majorAppliance);
            }
            else
            {
                var majorApplianceInDb = _context.Items.OfType<MajorAppliance>().Single(m => m.Id == majorAppliance.Id);

                majorApplianceInDb.Name = majorAppliance.Name;
                majorApplianceInDb.Price = majorAppliance.Price;
                majorApplianceInDb.SKU = majorAppliance.SKU;
                majorApplianceInDb.Warranty = majorAppliance.Warranty;
                majorApplianceInDb.Model = majorAppliance.Model;
                majorApplianceInDb.Company = majorAppliance.Company;
                majorApplianceInDb.ElectronicSpecifications = majorAppliance.ElectronicSpecifications;
                majorApplianceInDb.MajorApplianceSize = majorAppliance.MajorApplianceSize;
                majorApplianceInDb.MajorApplianceType = majorAppliance.MajorApplianceType;
            }
            _context.SaveChanges();

            return View("ItemForm");
        }

        //Returns the MouseAndKeyBoardForm
        [HttpPost]
        [Authorize(Roles = UserRoles.CanManageItems)]
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
        [Authorize(Roles = UserRoles.CanManageItems)]
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
        [Authorize(Roles = UserRoles.CanManageItems)]
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
        [Authorize(Roles = UserRoles.CanManageItems)]
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