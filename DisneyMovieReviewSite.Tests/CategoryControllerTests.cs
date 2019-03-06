using DisneyMovieReviewSite.Controllers;
using DisneyMovieReviewSite.Models;
using DisneyMovieReviewSite.Repositories;
using Microsoft.AspNetCore.Mvc;
using NSubstitute;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DisneyMovieReviewSite.Tests
{
    public class CategoryControllerTests
    {
        CategoryController underTest;
        private ICategoryRepository repo;

        public CategoryControllerTests()
        {
            repo = Substitute.For<ICategoryRepository>();
            underTest = new CategoryController(repo);
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
        public void Index_Model_Is_Expected_Model()
        {
            var expectedModel = new List<Category>();
            repo.GetAll().Returns(expectedModel);

            var result = underTest.Index();
            var model = (IEnumerable<Category>)result.Model;
            Assert.Equal(expectedModel, model);
        }
        [Fact]
        public void Details_Model_Is_Expected_Model()
        {
            var expectedId = 2;
            var expectedModel = new Category();
            repo.GetByID(expectedId).Returns(expectedModel);

            var result = underTest.Details(expectedId);
            var model = (Category)result.Model;

            Assert.Equal(expectedModel, model);
        }

    }
}
