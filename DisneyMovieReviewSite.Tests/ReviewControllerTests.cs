using DisneyMovieReviewSite.Controllers;
using DisneyMovieReviewSite.Models;
using DisneyMovieReviewSite.Repositories;
using Microsoft.AspNetCore.Mvc;
using NSubstitute;
using System.Collections.Generic;
using Xunit;

namespace DisneyMovieReviewSite.Tests
{
    public class ReviewControllerTests
    {
        ReviewController underTest;
        private IReviewRepository repo;

        public ReviewControllerTests()
        {
            repo = Substitute.For<IReviewRepository>();
            underTest = new ReviewController(repo);
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
        public void Can_Create_Review()
        {
            //var reviewRepo = new ReviewRepository(null);
            //var underTest = new ReviewController(reviewRepo);

            //var result = underTest.Create();

            //Assert.IsType<ViewResult>(result);

            var expectedId = 2;
            var expectedModel = new Review();
            repo.GetByID(expectedId).Returns(expectedModel);

            var result = underTest.Details(expectedId);
            var model = (Review)result.Model;

            Assert.Equal(expectedModel, model);

        }

        [Fact]
        public void Index_Model_Is_Expected_Model()
        {
            var expectedModel = new List<Review>();
            repo.GetAll().Returns(expectedModel);

            var result = underTest.Index();
            var model = (IEnumerable<Review>)result.Model;
            Assert.Equal(expectedModel, model);
        }
        [Fact]
        public void Details_Model_Is_Expected_Model()
        {
            var expectedId = 2;
            var expectedModel = new Review();
            repo.GetByID(expectedId).Returns(expectedModel);

            var result = underTest.Details(expectedId);
            var model = (Review)result.Model;

            Assert.Equal(expectedModel, model);
        }
    }
}
