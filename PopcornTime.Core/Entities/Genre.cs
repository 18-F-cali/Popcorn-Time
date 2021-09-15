using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace PopcornTime.Core.Entities
{
    public class Genre
    {
        [Key]
        public int Id { get; set; }
        public MovieCategory MovieCategory { get; set; }

        [NotMapped]
        public string CategoryName => Enum.GetName(MovieCategory.GetType(), this);

        public List<Movie> Movies { get; set; } 

    }
}
