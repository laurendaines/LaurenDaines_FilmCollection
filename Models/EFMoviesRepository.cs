using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaurenDaines_FilmCollection.Models
{
    public class EFMoviesRepository : IMoviesRepository
    {
        private MoviesDbContext _context;

        public EFMoviesRepository (MoviesDbContext context)
        {
            _context = context;
        }

        public IQueryable<Movie> Movies => _context.Movies;
    }
}
