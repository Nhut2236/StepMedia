using System.ComponentModel.DataAnnotations;

namespace Exercise.Apis.Models
{
    public class StudentModel : PersonModel
    {
        [Required]
        public DateTime DateOfBirth { get; set; }
    }
}

