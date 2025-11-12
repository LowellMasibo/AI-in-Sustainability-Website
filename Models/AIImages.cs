using System.ComponentModel.DataAnnotations;

namespace AspNetCoreMvcWebSite.Models
{
    public class AIImages
    {
        public AIImages()
        {
            Prompt = "";
            ImageGenerator = "";
            Filename = "";
        }
        [Required]
        public int Id { get; set; } 

        [Required]
        public string Prompt { get; set; }

        [Required]
        [Display(Name = "Image Generator")]
        public string ImageGenerator { get; set; }

        [Display(Name = "Upload Date")]
        public DateTime UploadDate { get; set; }
        public string Filename { get; set; }
        public int Like { get; set; }
        public bool CanIncreaseLike { get; set; }
        public int LikesCount { get; set; }
    }
}