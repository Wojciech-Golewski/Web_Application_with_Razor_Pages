using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace Web_Application_with_Razor_Pages.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new Web_Application_with_Razor_PagesContext(
                serviceProvider.GetRequiredService<DbContextOptions<Web_Application_with_Razor_PagesContext>>()))
            {
                // Looking for any movies
                if (context.Movie.Any())
                {
                    return; // DB has been seeded
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "Very Nice Mooovie",
                        ReleaseDate = DateTime.Parse("1999-3-3"),
                        Genre = "Romantic Comedy",
                        Price = 7
                    },
                    new Movie
                    {
                        Title = "Really awesome adventure",
                        ReleaseDate = DateTime.Parse("1789-4-11"),
                        Genre = "Comedy",
                        Price = 50
                    },
                    new Movie
                    {
                        Title = "Meoooooooooow",
                        ReleaseDate = DateTime.Parse("2018-1-1"),
                        Genre = "Cat type of movie",
                        Price = 100
                    },
                    new Movie
                    {
                        Title = "Sad Short Car",
                        ReleaseDate = DateTime.Parse("1999-9-9"),
                        Genre = "Adventure, Action",
                        Price = 10
                    },
                    new Movie
                    {
                        Title = "Quite a nice date",
                        ReleaseDate = DateTime.Parse("1899-3-3"),
                        Genre = "Romantic",
                        Price = 20
                    },
                    new Movie
                    {
                        Title = "12",
                        ReleaseDate = DateTime.Parse("1999-3-3"),
                        Genre = "Romantic Comedy",
                        Price = 7
                    },
                    new Movie
                    {
                        Title = "13",
                        ReleaseDate = DateTime.Parse("1999-3-3"),
                        Genre = "Romantic Comedy",
                        Price = 7
                    },
                    new Movie
                    {
                        Title = "V14",
                        ReleaseDate = DateTime.Parse("1999-3-3"),
                        Genre = "Romantic Comedy",
                        Price = 7
                    },
                    new Movie
                    {
                        Title = "15",
                        ReleaseDate = DateTime.Parse("1999-3-3"),
                        Genre = "Romantic Comedy",
                        Price = 7
                    },
                    new Movie
                    {
                        Title = "16",
                        ReleaseDate = DateTime.Parse("1999-3-3"),
                        Genre = "Romantic Comedy",
                        Price = 7
                    },
                    new Movie
                    {
                        Title = "A bad Movie",
                        ReleaseDate = DateTime.Parse("1979-3-3"),
                        Genre = "Horror",
                        Price = 55
                    }
                );

                context.SaveChanges();
            }
        }
    }
}