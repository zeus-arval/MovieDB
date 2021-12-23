using Domain;
using Domain.Common.Aids;
using Infra;
using Service.Common;

namespace Service
{
    public class MoviesService : BaseService<Movie, MovieDetails>
    {
        public MoviesService() : base(new MoviesRepo()) { }

        public MovieDetails GetMovieDetailsById(int id)
        {
            if (Items is null) return null;
            if (id < 0 || id > Items.Count) return null;
            Movie movie = _repo.Get(id);
            return Copier.CopyMembers(movie, new MovieDetails()) ?? new MovieDetails();
        }
    }
}
