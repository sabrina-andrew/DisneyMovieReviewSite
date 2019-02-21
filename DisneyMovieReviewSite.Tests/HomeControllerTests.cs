using DisneyMovieReviewSite.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using Xunit;

namespace DisneyMovieReviewSite.Tests
{
    public class HomeControllerTests
    {       
        [Fact]
        public void Index_Has_A_Review()
        {
            var underTest = new HomeController();
            var result = underTest.Index();

            Assert.IsType<ViewResult>(result);
        }
    }
}
