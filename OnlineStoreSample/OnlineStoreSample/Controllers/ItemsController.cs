using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineStoreSample.Models;
using OnlineStoreSample.Models.ItemModels;

namespace OnlineStoreSample.Controllers
{
    public class ItemsController : Controller
    {
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