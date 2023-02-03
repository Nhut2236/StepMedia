using System.ComponentModel.DataAnnotations;

namespace Exercise.Apis.Models
{
    public class PersonModel
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string FullName { get; set; }
    }
}

