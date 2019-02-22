﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DisneyMovieReviewSite.Models
{
    
    public class Movie
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public string Content { get; set; }
        public string Rating { get; set; }
        public string Category { get; set; }
        public string ImgPath { get; set; }
    }
}