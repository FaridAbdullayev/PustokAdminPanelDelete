using PustokHomework.Helpers;
using System.ComponentModel.DataAnnotations.Schema;

namespace PustokHomework.Models
{
    public class Slider
    {
        public int Id { get; set; }

        public string Title1 { get; set; }
        public string Title2 { get; set; }
        public string BtnText { get; set; }
        public string BtnUrl { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        [NotMapped]
        [FileSize(2 * 1024 * 1024)]
        public IFormFile? ImageFile { get; set; }
        public int Order { get; set; }    
    }
}
