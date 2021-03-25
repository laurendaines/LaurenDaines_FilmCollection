using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace LaurenDaines_FilmCollection.Models
{
    public static class tempStorage
    {
        private static List<Movie> movieList = new List<Movie>();
        public static IEnumerable<Movie> Movies => movieList;
        public static void AddMovie(Movie movies)
        {
            movieList.Add(movies);
        }
    }
}