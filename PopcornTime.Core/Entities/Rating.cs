using System.ComponentModel.DataAnnotations;


namespace PopcornTime.Core.Entities
{
    public class Rating : BaseEntity
    {
        [Required]
        [Range(0.0,5.0,ErrorMessage="Rating should be between 0 and 5")]
        public double Value { get; set; }

        [Required]
        public int MovieId { get; set; }
        public Movie Movie { get; set; }
        [Required]
        public int UserId { get; set; }

        public User User { get; set; }

    }
}
