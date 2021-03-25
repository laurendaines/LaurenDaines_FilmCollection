using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaurenDaines_FilmCollection.Models
{
    public interface IMoviesRepository
    {
        IQueryable<Movie> Movies { get; }
    }
}
