using Data;
using Domain.Common;

namespace Domain
{
    /// <summary>
    /// Domain with movie's details
    ///     Title: String
    ///     Description: String
    ///     Year: Int
    ///     Rating: Int
    /// </summary>
    public class MovieDetails : BaseEntity<MovieData>
    {
        public MovieDetails() : this(null) { }
        public MovieDetails(MovieData movie) : base(movie) { }
        public string Title => Data?.Title ?? string.Empty;
        public string Description => Data?.Description ?? string.Empty;
        public int Year => Data?.Year ?? int.MinValue;
        public int Rating => Data?.Rating ?? int.MinValue;
    }
}
