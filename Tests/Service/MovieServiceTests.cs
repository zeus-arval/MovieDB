using Data;
using Domain.Common.Aids;
using Facade;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Service;
using System.Collections.Generic;
using System.Linq;

namespace Tests.Service
{
    [TestClass]
    public class MovieServiceTests
    {
        private MoviesService _service;
        [TestInitialize]
        public void Initialize() 
        {
            _service = new MoviesService();
        }

        [TestMethod]
        public void TestGetMovieDetailsById()
        {
            for(int i = 0; i < MoviesList.movies.Count; i++)
            {
                int id = i;
                MovieDetailsViewModel actualVM = _service.GetMovieDetailsById(id);

                MovieDetailsViewModel expectedVM = Copier.CopyMembers(MoviesList.movies[id], new MovieDetailsViewModel());
                Assert.AreEqual(actualVM.Description, expectedVM.Description);
                Assert.AreEqual(actualVM.Rating, expectedVM.Rating);
                Assert.AreEqual(actualVM.Title, expectedVM.Title);
                Assert.AreEqual(actualVM.Year, expectedVM.Year);
            }
        }

        [TestMethod]
        public void TestGetList()
        {
            List<MovieViewModel> actualVMList = _service.GetList();
            for(int i = 0; i < MoviesList.movies.Count; i++)
            {
                MovieData movie = MoviesList.movies[i];
                CategoryData category = MoviesList.categories.FirstOrDefault(c => c.Id == movie.CategoryId);
                MovieViewModel expectedVM = new MovieViewModel();
                expectedVM.CategoryName = category.Name;
                Copier.CopyMembers(movie, expectedVM);
                Assert.AreEqual(actualVMList[i].CategoryName, expectedVM.CategoryName);
                Assert.AreEqual(actualVMList[i].Rating, expectedVM.Rating);
                Assert.AreEqual(actualVMList[i].Title, expectedVM.Title);
                Assert.AreEqual(actualVMList[i].Year, expectedVM.Year);
            }
        }
    }
}
