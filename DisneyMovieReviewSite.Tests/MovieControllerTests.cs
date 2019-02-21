using DisneyMovieReviewSite.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DisneyMovieReviewSite.Tests
{
    public class MovieControllerTests
    {

        [Fact]
        public void Index_Returns_A_View_Result()
        {
            var underTest = new MovieController();
            var result = underTest.Index();

            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Details_Has_A_View()
        {
            var underTest = new MovieController();
            var result = underTest.Details(1);
            
            Assert.IsType<ViewResult>(result);
        }

    }
}
