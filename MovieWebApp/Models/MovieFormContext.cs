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
        public DbSet<Category> Categories { get; set; }

        // Seed data
        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Category>().HasData(
                new Category { CategoryId = 1, CategoryName = "Action/Adventure" },
                new Category { CategoryId = 2, CategoryName = "Comedy" },
                new Category { CategoryId = 3, CategoryName = "Drama" },
                new Category { CategoryId = 4, CategoryName = "Family" },
                new Category { CategoryId = 5, CategoryName = "Horror/Suspense" },
                new Category { CategoryId = 6, CategoryName = "Miscellaneous" }
            );

            mb.Entity<MovieForm>().HasData(

                new MovieForm
                {
                    MovieId = 1,
                    CategoryId = 1,
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
                    CategoryId = 4,
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
                    CategoryId = 3,
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
