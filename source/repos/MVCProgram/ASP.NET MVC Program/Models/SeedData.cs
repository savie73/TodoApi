using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace MvcMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMovieContext(
                serviceProvider.GetRequiredService<DbContextOptions<MvcMovieContext>>()))
            {
                // Look for any movies.
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }

                context.Movie.AddRange(
                     new Movie
                     {
                         Title = "Meet the Mormons",
                         ReleaseDate = DateTime.Parse("2014-10-10"),
                         Genre = "Family",
                         Rating = "G",
                         Price = 6.99M
                     },

                     new Movie
                     {
                         Title = "Saints and Soldiers ",
                         ReleaseDate = DateTime.Parse("2003-9-11"),
                         Genre = "War",
                         Rating = "PG-13",
                         Price = 1.33M
                     },

                     new Movie
                     {
                         Title = "The Saratov Approach",
                         ReleaseDate = DateTime.Parse("2013-10-23"),
                         Genre = "Action",
                         Rating = "PG",
                         Price = 1.00M
                     },

                   new Movie
                   {
                       Title = "The Other Side of Heaven",
                       ReleaseDate = DateTime.Parse("2001-12-14"),
                       Genre = "Family",
                       Rating = "PG",
                       Price = 3.99M
                   },

                   new Movie
                   {
                       Title = "The RM",
                       ReleaseDate = DateTime.Parse("2003-10-10"),
                       Genre = "Family",
                       Rating = "PG",
                       Price = 1.12M
                   },

                   new Movie
                   {
                       Title = "The Best Two Years",
                       ReleaseDate = DateTime.Parse("2003-12-11"),
                       Genre = "Comedy",
                       Rating = "PG",
                       Price = 4.00M
                   },

                   new Movie
                   {
                       Title = "17 Miracles",
                       ReleaseDate = DateTime.Parse("2011-6-3"),
                       Genre = "History",
                       Rating = "PG",
                       Price = 6.99M
                   },

                   new Movie
                   {
                       Title = "God's Army",
                       ReleaseDate = DateTime.Parse("2000-11-14"),
                       Genre = "Drama",
                       Rating = "PG",
                       Price = 2.99M
                   },

                   new Movie
                   {
                       Title = "The Work and the Glory",
                       ReleaseDate = DateTime.Parse("2004-11-24"),
                       Genre = "Drama",
                       Rating = "PG",
                       Price = 6.34M
                   },

                   new Movie
                   {
                       Title = "The Cokeville Miracle",
                       ReleaseDate = DateTime.Parse("2015-6-05"),
                       Genre = "Drama",
                       Rating = "G",
                       Price = 6.99M
                   }


                );
                context.SaveChanges();

                //does this go here?
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded.
                }
            }

        }
    }
}
