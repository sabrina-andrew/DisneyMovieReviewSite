using DisneyMovieReviewSite.Controllers;
using DisneyMovieReviewSite.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Xunit;
using NSubstitute;
using DisneyMovieReviewSite.Models;

namespace DisneyMovieReviewSite.Tests
{
    public class MovieControllerTests
    {
        MovieController underTest;
        private IMovieRepository repo;

        public MovieControllerTests()
        {
            repo = Substitute.For<IMovieRepository>();
            underTest = new MovieController(repo);
        }

        [Fact]
        public void Index_Returns_A_View_Result()
        {
           var result = underTest.Index();

            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Details_Has_A_View()
        {
            var result = underTest.Details(1);
            
            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Can_Create_Movie()
        {
            var movieRepo = new MovieRepository(null);
            var underTest = new MovieController(movieRepo);
            
            var result = underTest.Create();

            Assert.IsType<ViewResult>(result);

        }

        [Fact]
        public void Index_Model_Is_Expected_Model()
        {
            var expectedModel = new List<Movie>();
            repo.GetAll().Returns(expectedModel);

            var result = underTest.Index();
            var model = (IEnumerable<Movie>)result.Model;
            Assert.Equal(expectedModel, model);
        }
        [Fact]
        public void Details_Model_Is_Expected_Model()
        {
            var expectedId = 2;
            var expectedModel = new Movie();
            repo.GetByID(expectedId).Returns(expectedModel);

            var result = underTest.Details(expectedId);
            var model = (Movie)result.Model;

            Assert.Equal(expectedModel, model);
        }

    }
}
