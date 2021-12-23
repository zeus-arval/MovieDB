using Data;
using Domain;
using Domain.Common.Aids;
using Facade;
using Infra;
using Service.Common;

namespace Service
{
    /// <summary>
    /// Movie's service 
    ///     Gets Movie Details' View Model by Id: Int
    /// </summary>
    public class MoviesService : BaseService<Movie, MovieDetails, MovieData, MovieViewModel>
    {
        public MoviesService() : base(new MoviesRepo()) { }

        public MovieDetailsViewModel GetMovieDetailsById(int id)
        {
            if (Items is null) GetItemsFromRepo();
            if (id < 0 || id > Items.Count) return null;
            MovieData movie = _repo.Get(id);
            return Copier.CopyMembers(movie, new MovieDetailsViewModel());
        }
    }
}
