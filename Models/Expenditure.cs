using MovieManagement.Enum;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieManagement.Models
{
    public class Crew
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Gender is required")]
        public Gender Sex { get; set; }

        [Required(ErrorMessage = "Date of Birth is required")]
        public DateTime DOB { get; set; }

        [Required(ErrorMessage = "Experience is required")]
        public float ExperienceInYears { get; set; }

        [Required(ErrorMessage = "Field is required")]
        public Field Field { get; set; }
        public List<Movie> Movies { get; set; }
    }
}