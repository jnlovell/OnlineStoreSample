using OnlineStoreSample.Models;
using OnlineStoreSample.Models.SpecificItemModels;
using System.Collections.Generic;
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
            var itemList = GetItems();

            return View(itemList);
        }

        public ActionResult Detail(int Id)
        {
            var item = GetItems().SingleOrDefault(i => i.Id == Id);

            if (item == null)
                return HttpNotFound();

            return View(item);
        }

        public ActionResult New()
        {
            Desktop desktop = new Desktop();
            List<string> itemTypes = new List<string>
            {
                "Camera", "Carrying Bag", "Desktop", "Game Console", "Laptop", "Major Appliance", "Mouse And Keyboard", "Movie", "Software", "Video Game"
            };
            return View("ItemForm", itemTypes);
        }

        [HttpPost]
        public ActionResult NewSelected(string itemType)
        {
            if (itemType == "Desktop")
            {
                Desktop desktop = new Desktop();
                return View("DesktopForm", desktop);
            }


            return View();
        }

        public List<Item> GetItems()
        {
            var ItemList = new List<Item>();

            var item1 = new Item
            {
                Id = 1,
                Name = "iPhone",
                Model = "DKFL453LF",
                Price = 150.00,
                SKU = 4575346
            };

            var item2 = new Item
            {
                Id = 2,
                Name = "iPad",
                Model = "DTRHG45345",
                Price = 400.00,
                SKU = 4567535
            };

            ItemList.Add(item1);
            ItemList.Add(item2);

            return ItemList;
        }
    }
}