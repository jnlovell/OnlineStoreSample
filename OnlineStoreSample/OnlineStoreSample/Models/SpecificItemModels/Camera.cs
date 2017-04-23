using OnlineStoreSample.Models.ItemModels;
using System.ComponentModel.DataAnnotations;

namespace OnlineStoreSample.Models.SpecificItemModels
{
    public class Camera : Electronic
    {
        [Display(Name = "Frames Per Second")]
        public int CameraFPS { get; set; }
        [Display(Name = "Camera Type: Video or Picture")]
        public string CameraType { get; set; }
        [Display(Name = "Resolution")]
        public string CameraResolution { get; set; }
    }
}