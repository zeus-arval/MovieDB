using System.Net.Http;
using System.Web.Http;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using System.Collections.Generic;
using Service;
using Facade;

namespace Soft.Controllers
{
    /// <summary>
    /// API controller for movies. Works with Information located in MoviesList static class
    /// Gets Movies' list
    /// Gets Movie Details by Movie Id: Int
    /// </summary>
    public class MoviesListController : ApiController 
    {
        private MoviesService _service = new MoviesService();

        [HttpGet]
        public HttpResponseMessage Get(DataSourceLoadOptions loadOptions) {
            List<MovieViewModel> movies = _service.GetList();
            return Request.CreateResponse(DataSourceLoader.Load(movies, loadOptions));
        }

        [HttpGet]
        public HttpResponseMessage GetMoviesDescriptions(int id, DataSourceLoadOptions loadOptions)
        {
            MovieDetailsViewModel detail = _service.GetMovieDetailsById(id);
            List<MovieDetailsViewModel> details = new List<MovieDetailsViewModel> { detail };
            return Request.CreateResponse(DataSourceLoader.Load(details ,loadOptions));
        }
    }
}