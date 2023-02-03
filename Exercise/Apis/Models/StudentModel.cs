using System.ComponentModel.DataAnnotations;

namespace Exercise.Apis.Models
{
    public class StudentModel : PersonModel
    {
        [Required]
        public DateTime DateOfBirth { get; set; }
        public int Age => DateTime.UtcNow.Year - DateOfBirth.Year;
    }
}

