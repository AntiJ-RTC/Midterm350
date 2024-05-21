using System.ComponentModel.DataAnnotations;

namespace Midterm350.Models
{
    public class Patient
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Species { get; set; }
        [Required]
        public string Breed { get; set; }
        [Required]
        [Range(1,99)]
        public int Age { get; set; }
        public string Medications { get; set; }
        public string MedicalHistory { get; set; }
        public string ImgURL { get; set; } = "https://th.bing.com/th/id/OIP.EqddAPv3NFR7SGAJykZ2PgHaHa?rs=1&pid=ImgDetMain";
    }
}
