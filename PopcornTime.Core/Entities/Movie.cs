using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace PopcornTime.Core.Entities
{
    public class Movie: BaseEntity
    {
        [Required]
        [MaxLength(length:120,ErrorMessage ="Movie name should not exceed character limit of 120")]
        public string Name { get; set; }

        public string Director { get; set; }

        [Required]
        public int Year { get; set; }

        [Required]
        [Range(0.0,5.0,ErrorMessage ="Rating should range between 0 to 5")]
        public double AvgRating { get; set; }

        [Required]
        public Visibility Visibility { get; set; }

        [Required]
        public bool Deleted { get; set; }

        public List<Genre> Genres { get; set; } = new List<Genre>();

        public List<Rating> Ratings { get; set; } = new List<Rating>();

        public List<Review> Reviews { get; set; } = new List<Review>();

        public List<MovieList> Lists { get; set; } = new List<MovieList>();


    }


    

    
}
