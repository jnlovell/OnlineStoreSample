using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Web;

namespace OnlineStoreSample.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public int SKU { get; set; }
        public double Price { get; set; }
        public string Company { get; set; }
    }
}