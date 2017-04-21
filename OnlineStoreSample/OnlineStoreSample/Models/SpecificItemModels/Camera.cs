using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Security.AccessControl;
using System.Web;
using OnlineStoreSample.Models.ItemModels;

namespace OnlineStoreSample.Models.SpecificItemModels
{
    public class Camera : Electronic
    {
        public int FPS { get; set; }
        public string CameraType { get; set; }
        public string Resolution { get; set; }
    }
}