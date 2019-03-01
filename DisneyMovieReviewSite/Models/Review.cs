using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DisneyMovieReviewSite.Models
{
    public class Review
    {
        public int ReviewID { get; set; }
        public int MovieID { get; set; }
        public virtual Movie Movie { get; set; }
        public string ReviewContent { get; set; }

        

    }
}
