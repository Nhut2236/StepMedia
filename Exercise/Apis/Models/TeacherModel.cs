using System.ComponentModel.DataAnnotations;

namespace Exercise.Apis.Models
{
    public class TeacherModel : PersonModel
    {
        [Required]
        public List<StudentModel> Students { get; set; }
    }
}