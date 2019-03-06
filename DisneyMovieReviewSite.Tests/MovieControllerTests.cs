﻿using DisneyMovieReviewSite.Controllers;
using DisneyMovieReviewSite.Repositories;
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
            var underTest = new MovieController(null);
            var result = underTest.Index();

            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Details_Has_A_View()
        {
            var underTest = new MovieController(null);
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

    }
}
