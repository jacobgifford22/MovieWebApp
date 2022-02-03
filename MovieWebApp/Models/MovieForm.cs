using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieWebApp.Models
{
    public class MovieForm
    {
        [Key]
        [Required]
        public int MovieId { get; set; }
        
        [Required(ErrorMessage = "Please enter a title.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Please enter a valid year (####).")]
        public ushort Year { get; set; }

        [Required(ErrorMessage = "Please enter a director.")]
        public string Director { get; set; }

        [Required]
        public string Rating { get; set; }

        [Required]
        public bool Edited { get; set; }

        public string LentTo { get; set; }

        [MaxLength(25)]
        public string Notes { get; set; }

        // Build foreign key relationship
        [Required(ErrorMessage = "Please select a category.")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
