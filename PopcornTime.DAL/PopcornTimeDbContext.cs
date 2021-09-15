using Microsoft.EntityFrameworkCore;
using PopcornTime.Core.Entities;
using System;

namespace PopcornTime.DAL
{
    public class PopcornTimeDbContext:DbContext
    {

        public PopcornTimeDbContext(DbContextOptions options):base(options)
        {
                
        }

         protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //additional config.

            modelBuilder.Entity<Movie>().Property(x => x.Visibility).HasDefaultValue(Visibility.Visible);
            modelBuilder.Entity<Movie>().Property(x => x.Deleted).HasDefaultValue<bool>(false);


            modelBuilder.Entity<Rating>().HasAlternateKey(x => new { x.MovieId, x.UserId });
            modelBuilder.Entity<Review>().HasAlternateKey(x => new { x.MovieId, x.UserId });

            modelBuilder.Entity<User>().HasAlternateKey(x => x.Email);
            modelBuilder.Entity<User>().HasAlternateKey(x => x.Username);
            modelBuilder.Entity<User>().Property(x => x.IsAdmin).HasDefaultValue<bool>(false);


        }
    }
}
