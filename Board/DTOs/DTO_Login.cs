using System.ComponentModel.DataAnnotations;

namespace Board.DTOs
{
    public class DTO_Login
    {
        [Required(ErrorMessage = "")]
        public string user { get; set; }
        
        [Required]
        public string password { get; set; }
        
        
    }
}