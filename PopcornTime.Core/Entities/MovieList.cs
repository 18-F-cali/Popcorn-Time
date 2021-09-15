using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace PopcornTime.Core.Entities
{
    public class MovieList:BaseEntity
    {
        
        [Required]
        [MaxLength(100,ErrorMessage ="List name cannot be longer than 100 characters")]
        public string Name { get; set; }

        [Required]
        public int UserId { get; set; }

        public User User { get; set; }

        public List<Movie> Movies { get; set; } = new List<Movie>();

    }
}
