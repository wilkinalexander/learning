using System.ComponentModel.DataAnnotations;

namespace Commander.DTOs
{
    public class CommandUpdateDTO
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