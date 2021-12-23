using Data;
using Domain.Common;
using System.Collections.Generic;
using System.Linq;

namespace Domain
{
    public class Movie : BaseEntity<MovieData>
    {
        public Movie() : this(null, null) { }
        public Movie(MovieData movie, List<CategoryData> categories) : base(movie)
        {
            CategoryName = categories.FirstOrDefault(x => x?.Id == CategoryId).Name;
        }
        public string Title => Data?.Title ?? string.Empty;
        public int Year => Data?.Year ?? int.MinValue;
        public int Rating => Data?.Rating ?? int.MinValue;
        private int CategoryId => Data?.CategoryId ?? int.MinValue;
        public string CategoryName { get; }
    }
}
