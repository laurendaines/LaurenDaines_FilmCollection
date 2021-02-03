using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LaurenDaines_FilmCollection.Models
{
    public class ApplicationResponse
    {
        [Required(ErrorMessage = "You must enter a Category")]
        public string Category { get; set; }
        [Required(ErrorMessage =  "You must enter a Title")]
        public string Title { get; set; }
        [Required]
        public int Year { get; set; }
        [Required(ErrorMessage =  "You must enter a Director")]
        public string Director { get; set; }
        [Required(ErrorMessage =  "You must enter a Rating")]
        public string Rating { get; set; }
        public string Edited { get; set; }
        public string LentTo { get; set; }
        [MaxLength(25, ErrorMessage =  "Notes can have a max of 25 characters")]
        public string Notes { get; set; }
    }
}