using System.ComponentModel.DataAnnotations;

namespace PopcornTime.Core.Entities
{
   public class Review:BaseEntity
    {
        [Required]
        [MaxLength(5000,ErrorMessage ="Review cannot exceed characters limit of 5000")]
        public string Text { get; set; }

        [Required]
        public int MovieId { get; set; }
        public Movie Movie { get; set; }


        [Required]
        public int UserId { get; set; }

        public User User { get; set; }

    }
}
