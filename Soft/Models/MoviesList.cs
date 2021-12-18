using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Soft.Models
{
    public class MoviesList
    {
        public static List<Movie> Movies = new List<Movie>()
        {
            new Movie()
            {
                MovieId = 1,
                Title = "First",
                Year = 2021,
                Description = "First movie on this site",
                Rating = 10,
                CategoryId = 0,
                CategoryName = "Thriller"
            },
            new Movie()
            {
                MovieId = 2,
                Title = "Second",
                Year = 2020,
                Description = "Second movie on this site",
                Rating = 7,
                CategoryId = 1,
                CategoryName = "Thriller"
            },
            new Movie()
            {
                MovieId = 3,
                Title = "Third",
                Year = 2021,
                Description = "Third movie on this site",
                Rating = 8,
                CategoryId = 0,
                CategoryName = "Thriller"
            },
        };
    }
}