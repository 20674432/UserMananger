using System.ComponentModel.DataAnnotations;

namespace UserCRUD.Models
{
    public class User
    {
        [Key]
        public int User_id { get; set; }
        [Required]
        public string First_name { get; set; }
        [Required]
        public string Last_name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        [RegularExpression(@"^\d{13}$", ErrorMessage = "Invalid ID Number")]
        public string Id_number { get; set; }
        [Required]
        public DateTime Birth_date { get; set; }
       
        
    }
}
