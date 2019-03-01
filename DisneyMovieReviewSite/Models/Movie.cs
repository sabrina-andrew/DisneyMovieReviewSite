using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DisneyMovieReviewSite.Models
{
    
    public class Movie
    {
        public int MovieID { get; set; }
        public string Name { get; set; }
        public string Synopsis { get; set; }
        public double Rating { get; set; }
        public string ImgPath { get; set; }
        public int ReleaseYear { get; set; }
        public int RunTime { get; set; }
        public string UserName { get; set; }
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }
        
    }
}
