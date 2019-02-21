using DisneyMovieReviewSite.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using Xunit;

namespace DisneyMovieReviewSite.Tests
{
    public class HomeControllerTests
    {       
        [Fact]
        public void Index_Returns_A_View_Result()
        {
            var underTest = new HomeController();
            var result = underTest.Index();

            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Details_Has_A_View()
        {
            var underTest = new HomeController();
            var result = underTest.Details();

            Assert.IsType<ViewResult>(result);
        }
    }
}
