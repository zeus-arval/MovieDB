using System.Linq;
using System.Net.Http;
using System.Web.Http;
using Soft.Models;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using System;
using System.Collections.Generic;

namespace Soft.Controllers {
    public class MoviesListController : ApiController {

        [HttpGet]
        public HttpResponseMessage Get(DataSourceLoadOptions loadOptions) {
            return Request.CreateResponse(DataSourceLoader.Load(MoviesList.Movies, loadOptions));
        }

        [HttpGet]
        public HttpResponseMessage GetMoviesDescriptions(int id, DataSourceLoadOptions loadOptions)
        {
            var description = MoviesList.Movies.Where(m => m.MovieId == id).Select(m => m.Description).FirstOrDefault();
            return Request.CreateResponse(DataSourceLoader.Load(description, loadOptions));
        }
    }
}