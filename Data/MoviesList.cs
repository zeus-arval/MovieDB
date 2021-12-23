using System.Collections.Generic;

namespace Data
{
    /// <summary>
    /// Class with hardcoded information in CategoryData and MovieData format
    /// MoviesList is used as data storage in this project
    /// </summary>
    public static class MoviesList
    {
        public static readonly List<CategoryData> categories = new List<CategoryData>
        {
            new CategoryData() { Name = "Thriller", Id = 0 },
            new CategoryData() { Name = "Action", Id = 1 },
            new CategoryData() { Name = "Comedy", Id = 2 },
            new CategoryData() { Name = "Drama", Id = 3 },
            new CategoryData() { Name = "Fantasy", Id = 4 },
            new CategoryData() { Name = "Horror", Id = 5 },
            new CategoryData() { Name = "Mystery", Id = 6 },
        };

        public static readonly List<MovieData> movies = new List<MovieData>()
        {
            new MovieData()
            {
                Id = 0,
                CategoryId = 0,
                Year = 2021,
                Title = "The Guilty",
                Description = "The Guilty is a 2021 American crime...",
                Rating = 6
            },new MovieData()
            {
                Id = 1,
                CategoryId = 0,
                Year = 2002,
                Title = "Red Dragon",
                Description = "A retired FBI agent with psychological...",
                Rating = 7
            },new MovieData()
            {
                Id = 2,
                CategoryId = 0,
                Year = 2001,
                Title = "Mulholland Drive",
                Description = "After a car wreck on the winding...",
                Rating = 8
            },new MovieData()
            {
                Id = 3,
                CategoryId = 1,
                Year = 2017,
                Title = "Logan",
                Description = "In a future where mutants...",
                Rating = 7
            },new MovieData()
            {
                Id = 4,
                CategoryId = 1,
                Year = 2015,
                Title = "Star Wars VII: The Force Awakens",
                Description = "As a new threat to the galaxy rises...",
                Rating = 8
            },new MovieData()
            {
                Id = 5,
                CategoryId = 1,
                Year = 1933,
                Title = "King Kong",
                Description = "A film crew goes to a tropical island...",
                Rating = 8
            },new MovieData()
            {
                Id = 6,
                CategoryId = 2,
                Year = 1994,
                Title = "Pulp Fiction",
                Description = "The lives of two mob hitmen...",
                Rating = 9
            },new MovieData()
            {
                Id = 7,
                CategoryId = 2,
                Year = 2019,
                Title = "Booksmart",
                //Description = "",
                //Rating = 
            },new MovieData()
            {
                Id = 8,
                CategoryId = 3,
                Year = 1941,
                Title = "Citizen Kane",
                Description = "On the eve of their high school graduation...",
                Rating = 6
            },new MovieData()
            {
                Id = 9,
                CategoryId = 3,
                Year = 2018,
                Title = "Mission Impossible - Fallout",
                Description = "Ethan Hunt and his IMF team...",
                Rating = 8
            },new MovieData()
            {
                Id = 10,
                CategoryId = 3,
                Year = 1972,
                Title = "The Godfather",
                Description = "The Godfather follows Vito Corleone...",
                Rating = 9
            },new MovieData()
            {
                Id = 11,
                CategoryId = 4,
                Year = 2002,
                Title = "The Lord of the Rings: The Two Towers",
                Description = "While Frodo and Sam edge closer to Mordor...",
                Rating = 9
            },new MovieData()
            {
                Id = 12,
                CategoryId = 4,
                Year = 2012,
                Title = "The Hobbit: Unexpected Journey",
                Description = "A reluctant Hobbit, Bilbo Baggins...",
                Rating = 8
            },new MovieData()
            {
                Id = 13,
                CategoryId = 4,
                Year = 2013,
                Title = "Peter Pan",
                Description = "The Darling family children receive a visit from Peter...",
                Rating = 6
            },new MovieData()
            {
                Id = 14,
                CategoryId = 4,
                Year = 1981,
                Title = "Excalibur",
                Description = "Merlin the magician helps Arthur Pendragon...",
                Rating = 6
            },new MovieData()
            {
                Id = 15,
                CategoryId = 5,
                Year = 2013,
                Title = "Oculus",
                Description = "A woman tries to exonerate her brother...",
                Rating = 5
            },new MovieData()
            {
                Id = 16,
                CategoryId = 5,
                Year = 1996,
                Title = "Scream",
                Description = "A year after the murder of her mother...",
                Rating = 7
            },new MovieData()
            {
                Id = 17,
                CategoryId = 5,
                Year = 2007,
                Title = "1408",
                Description = "A man who specialises in debunking...",
                Rating = 7
            },new MovieData()
            {
                Id = 18,
                CategoryId = 5,
                Year = 2003,
                Title = "A Tale Of Two Sisters",
                Description = "After spending time in a mental...",
                Rating = 7
            },new MovieData()
            {
                Id = 19,
                CategoryId = 6,
                Year = 2019,
                Title = "Us",
                Description = "A family's serene beach vacation...",
                Rating = 5
            },new MovieData()
            {
                Id = 20,
                CategoryId = 6,
                Year = 2005,
                Title = "Brick",
                Description = "A teenage loner pushes his way into...",
                Rating = 7
            },
        };
    }
}
