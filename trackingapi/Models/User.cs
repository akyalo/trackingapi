using System.ComponentModel.DataAnnotations;

namespace trackingapi.Models
{
    public class User
    {
        
        [Required]
        public int Id { get; set; }  
 
        public string Name { get; set; }
        public DateTime dateofbirth { get; set; }
        public String userProfession { get; set; }
    }
}
