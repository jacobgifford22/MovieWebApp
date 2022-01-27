using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieWebApp.Models
{
    public class MovieFormContext : DbContext
    {
        // Constructor
        public MovieFormContext(DbContextOptions<MovieFormContext> options) : base(options)
        {
            // Leave blank for now
        }

        public DbSet<MovieForm> Movies { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<MovieForm>().HasData(

                new MovieForm
                {
                    MovieId = 1,
                    Category = "Action/Adventure",
                    Title = "Dark Knight, The",
                    Year = 2008,
                    Director = "Christopher Nolan",
                    Rating = "PG-13",
                    Edited = false,
                    LentTo = "Bob",
                    Notes = null
                },
                new MovieForm
                {
                    MovieId = 2,
                    Category = "Family",
                    Title = "Elf",
                    Year = 2003,
                    Director = "Jon Favreau",
                    Rating = "PG",
                    Edited = false,
                    LentTo = null,
                    Notes = null
                },
                new MovieForm
                {
                    MovieId = 3,
                    Category = "Drama",
                    Title = "Jojo Rabbit",
                    Year = 2019,
                    Director = "Taika Waititi",
                    Rating = "PG-13",
                    Edited = false,
                    LentTo = null,
                    Notes = null
                }
            );
        }
    }
}
