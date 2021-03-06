﻿using System;
using System.Collections.Generic;

namespace DisneyMovieReviewSite.Models
{
    
    public class Movie
    {
        public int MovieID { get; set; }
        public string Name { get; set; }
        public string Synopsis { get; set; }
        public decimal AverageRating { get; set; }
        public string ImgPath { get; set; }
        public int ReleaseYear { get; set; }
        public int RunTime { get; set; }
        public string UserName { get; set; }
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }
        public virtual List<Review> Reviews { get; set; }

        public decimal AverageCalculation()
        {   
            int totalRating = 0;
            foreach (var review in Reviews)
            {
                totalRating += review.UserRating;
            }

            if (Reviews.Count >0)
            {
                decimal averageRating = totalRating / Reviews.Count;

                decimal roundRating = Math.Round(averageRating, 1);

                AverageRating = roundRating;
            }
            return AverageRating;
        }
    }
}


