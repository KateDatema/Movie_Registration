using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieRegistration.Models
{
    public class Movie
    {
        public enum Genre
        {
            Drama,
            Comedy,
            Horror,
            Romance,
            Action
        }
        public int Id { get; set; }
        public string Title { get; set; }
        public Genre GenreType {get; set;}
        public int Year { get; set; }
        public int RunTime { get; set; }
    }
}
