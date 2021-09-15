using System.ComponentModel.DataAnnotations;


namespace PopcornTime.Core.Entities
{
   public class User:BaseEntity
    {

        [Required]
        [MaxLength(10,ErrorMessage ="Username should be more than 10 characters long")]
        public string Username { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        //Todo : Add Password pattern later for strenth
        //[RegularExpression("",ErrorMessage = "Password must fullfill requirements")]
        public string Password { get; set; }

        [Required]
        public bool IsAdmin { get; set; }

    }
}
