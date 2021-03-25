using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaurenDaines_FilmCollection.Models
{
    public class SeedData
    {
        public static void EnsurePopulated (IApplicationBuilder application)
        {
            MoviesDbContext context = application.ApplicationServices.
                CreateScope().ServiceProvider.GetRequiredService<MoviesDbContext>();
        
            if(context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if(!context.Movies.Any())
            {
                context.Movies.AddRange(

                    new Movie
                    {
                        Category = "Action/Adventure",
                        Title = "The Avengers", 
                        Year = 2012,
                        DirectorFirstName = "Joss",
                        DirectorLastName = "Whedon",
                        Rating = "PG-13",
                        Edited = false,
                        LentTo = "",
                        Notes = ""
                    }
                );

                context.SaveChanges();
            }
        }
    }
}
