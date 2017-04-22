using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using System.Web.DynamicData;
using System.Web.Mvc;
using OnlineStoreSample.Models;
using OnlineStoreSample.Models.ItemModels;
using OnlineStoreSample.Models.SpecificItemModels;

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

        public void New()
        {
            using (_context)
            {
                Desktop desktop = new Desktop()
                {
                    Name = "HP-Tower",
                    Company = "HP",
                    DesktopOperatingSystem = "Windows 10",
                    DesktopProcessor = "Intel",
                    DesktopRAM = 8,
                    DesktopStorageType = "Hard Drive",
                    ElectronicSpecifications = "HP Desktop Tower with 8GB RAM",
                    Model = "456-GHG-48W",
                    SKU = 45834756,
                    DesktopStorageSize = 500

                };

                _context.Items.Add(desktop);
                _context.SaveChanges();
            }

            //return View("ItemForm", newContext);
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