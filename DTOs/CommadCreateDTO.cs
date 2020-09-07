using System.ComponentModel.DataAnnotations;

namespace Commander.DTOs
{
    public class CommandCreateDTO
    {
        [Required]
        [MaxLength(100)]
        public string HowTo {get; set;}
        [Required]
        public string Line { get; set; }
        [Required]
        public string Platform { get; set; }

    }
}