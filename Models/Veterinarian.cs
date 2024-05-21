using System.ComponentModel.DataAnnotations;

namespace Midterm350.Models
{
    public class Veterinarian
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [Range(1,99)]
        public int YearsExperience { get; set; }
        public string Bio { get; set; }
        public string ImgURL { get; set; } = "https://cdn.pixabay.com/photo/2015/10/05/22/37/blank-profile-picture-973461_1280.png";
    }
}
