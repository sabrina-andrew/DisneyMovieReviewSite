using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        public int UserRating { get; set; }
        public string UserName { get; set; }
        

        

    }
}
