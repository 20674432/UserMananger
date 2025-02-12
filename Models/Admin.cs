using System.ComponentModel.DataAnnotations;

namespace UserCRUD.Models
{
    public class Admin
    {
        [Key]
        public int Admin_id { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string Admin_password { get; set; }
       
    }
}
