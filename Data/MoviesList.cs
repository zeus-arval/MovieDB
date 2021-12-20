using System.Collections.Generic;

namespace Data
{
    public class MoviesList
    {
        public readonly List<MovieData> movies;
        public readonly List<CategoryData> categories;
        public MoviesList()
        {
            categories = CreateCategoriesList();
            movies = CreateMoviesList();
        }

        private List<CategoryData> CreateCategoriesList()
            => new List<CategoryData>
            {
                new() { Name = "Thriller", Id = 0 },
                new() { Name = "Action", Id = 1 },
                new() { Name = "Comedy", Id = 2 },
                new() { Name = "Drama", Id = 3 },
                new() { Name = "Fantasy", Id = 4 },
                new() { Name = "Horror", Id = 5 },
                new() { Name = "Mystery", Id = 6 },
            };

        private List<MovieData> CreateMoviesList()
            => new List<MovieData>
            {
                new()
                {
                    Id = 0,
                    CategoryId = 0,
                    Year = 2021,
                    Title = "The Guilty",
                    Description = "The Guilty is a 2021 American crime thriller film directed and produced by Antoine Fuqua, from a screenplay by Nic Pizzolatto. " +
                    "A remake of the 2018 Danish film of the same name, the film stars Jake Gyllenhaal and Christina Vidal, with the voices of Ethan Hawke, Riley Keough," +
                    " Eli Goree, Da'Vine Joy Randolph, Paul...",
                    Rating = 6
                },new()
                {
                    Id = 1,
                    CategoryId = 0,
                    Year = 2002,
                    Title = "Red Dragon",
                    Description = "A retired FBI agent with psychological gifts is assigned to help track down 'The Tooth Fairy', a mysterious serial killer. Aiding him" + 
                    " is imprisoned forensic psychiatrist Dr. Hannibal 'The Cannibal' Lecter...",
                    Rating = 7
                },new()
                {
                    Id = 2,
                    CategoryId = 0,
                    Year = 2001,
                    Title = "Mulholland Drive",
                    Description = "After a car wreck on the winding Mulholland Drive renders a woman amnesiac, she and a perky Hollywood-hopeful search for clues and " +
                    "answers across Los Angeles in a twisting venture beyond dreams and reality...",
                    Rating = 8
                },new()
                {
                    Id = 3,
                    CategoryId = 1,
                    Year = 2017,
                    Title = "Logan",
                    Description = "In a future where mutants are nearly extinct, an elderly and weary Logan leads a quiet life. But when Laura, a mutant child pursued " +
                    "by scientists, comes to him for help, he must get her to safety...",
                    Rating = 7
                },new()
                {
                    Id = 4,
                    CategoryId = 1,
                    Year = 2015,
                    Title = "Star Wars VII: The Force Awakens",
                    Description = "As a new threat to the galaxy rises, Rey, a desert scavenger, and Finn, an ex-stormtrooper, must join Han Solo and Chewbacca to search" +
                    " for the one hope of restoring peace...",
                    Rating = 8
                },new()
                {
                    Id = 5,
                    CategoryId = 1,
                    Year = 1933,
                    Title = "King Kong",
                    Description = "A film crew goes to a tropical island for an exotic location shoot and discovers a colossal ape who takes a shine to their female blonde" +
                    " star. He is then captured and brought back to New York City for public exhibition...",
                    Rating = 8
                },new()
                {
                    Id = 6,
                    CategoryId = 2,
                    Year = 1994,
                    Title = "Pulp Fiction",
                    Description = "The lives of two mob hitmen, a boxer, a gangster and his wife, and a pair of diner bandits intertwine in four tales of violence and redemption.",
                    Rating = 9
                },new()
                {
                    Id = 7,
                    CategoryId = 2,
                    Year = 2019,
                    Title = "Booksmart",
                    //Description = "",
                    //Rating = 
                },new()
                {
                    Id = 8,
                    CategoryId = 3,
                    Year = 1941,
                    Title = "Citizen Kane",
                    Description = "On the eve of their high school graduation, two academic superstars and best friends realize they should have worked less and played more. " +
                    "Determined not to fall short of their peers, the girls try to cram four years of fun into one night...",
                    Rating = 6
                },new()
                {
                    Id = 9,
                    CategoryId = 3,
                    Year = 2018,
                    Title = "Mission Impossible - Fallout",
                    Description = "Ethan Hunt and his IMF team, along with some familiar allies, race against time after a mission gone wrong.",
                    Rating = 8
                },new()
                {
                    Id = 10,
                    CategoryId = 3,
                    Year = 1972,
                    Title = "The Godfather",
                    Description = "The Godfather follows Vito Corleone, Don of the Corleone family, as he passes the mantel to his unwilling son, Michael...",
                    Rating = 9
                },new()
                {
                    Id = 11,
                    CategoryId = 4,
                    Year = 2002,
                    Title = "The Lord of the Rings: The Two Towers",
                    Description = "While Frodo and Sam edge closer to Mordor with the help of the shifty Gollum, the divided fellowship makes a stand against " +
                    "Sauron's new ally, Saruman, and his hordes of Isengard...",
                    Rating = 9
                },new()
                {
                    Id = 12,
                    CategoryId = 4,
                    Year = 2012,
                    Title = "The Hobbit: Unexpected Journey",
                    //Description = "",
                    //Rating = 
                },new()
                {
                    Id = 13,
                    CategoryId = 4,
                    Year = 2013,
                    Title = "Peter Pan",
                    Description = "A reluctant Hobbit, Bilbo Baggins, sets out to the Lonely Mountain with a spirited group of dwarves to reclaim their mountain " +
                    "home, and the gold within it from the dragon Smaug...",
                    Rating = 8
                },new()
                {
                    Id = 14,
                    CategoryId = 4,
                    Year = 1981,
                    Title = "Excalibur",
                    Description = "Merlin the magician helps Arthur Pendragon unite the Britons around the Round Table of Camelot, even as dark forces conspire" +
                    " to tear it apart...",
                    Rating = 6
                },new()
                {
                    Id = 15,
                    CategoryId = 5,
                    Year = 2013,
                    Title = "Oculus",
                    Description = "A woman tries to exonerate her brother, who was convicted of murder, by proving that the crime was committed by a supernatural phenomenon...",
                    Rating = 5
                },new()
                {
                    Id = 16,
                    CategoryId = 5,
                    Year = 1996,
                    Title = "Scream",
                    Description = "A year after the murder of her mother, a teenage girl is terrorized by a new killer, who targets the girl and her friends by " +
                    "using horror films as part of a deadly game...",
                    Rating = 7
                },new()
                {
                    Id = 17,
                    CategoryId = 5,
                    Year = 2007,
                    Title = "1408",
                    Description = "A man who specialises in debunking paranormal occurrences checks into the fabled room 1408 in the Dolphin Hotel. Soon after " +
                    "settling in, he confronts genuine terror...",
                    Rating = 7
                },new()
                {
                    Id = 18,
                    CategoryId = 5,
                    Year = 2003,
                    Title = "A Tale Of Two Sisters",
                    Description = "After spending time in a mental institution, two devoted sisters return to the home of their father and cruel stepmother. Once " +
                    "there, in addition to dealing with their stepmother's obsessive, unbalanced ways, an interfering ghost also affects their...",
                    Rating = 7
                },new()
                {
                    Id = 19,
                    CategoryId = 6,
                    Year = 2019,
                    Title = "Us",
                    Description = "A family's serene beach vacation turns to chaos when their doppelgängers appear and begin to terrorize them...",
                    Rating = 5
                },new()
                {
                    Id = 20,
                    CategoryId = 6,
                    Year = 2005,
                    Title = "Brick",
                    Description = "A teenage loner pushes his way into the underworld of a high school crime ring to investigate the disappearance" +
                    " of his ex-girlfriend...",
                    Rating = 7
                },
            };
    }
}
