using Data;
using Domain;
using Infra.Common;
using System.Collections.Generic;

namespace Infra
{
    /// <summary>
    /// Movie's Repository
    ///     Transfers all movie data to entity(Domain)
    /// </summary>
    public class MoviesRepo : BaseRepo<Movie, MovieData>
    {
        private readonly List<CategoryData> _categories;
        public MoviesRepo() : base(MoviesList.movies)
        {
            _categories = MoviesList.categories;
        }

        protected internal override Movie ToEntity(MovieData d)
            => new Movie(d, _categories);
    }
}
