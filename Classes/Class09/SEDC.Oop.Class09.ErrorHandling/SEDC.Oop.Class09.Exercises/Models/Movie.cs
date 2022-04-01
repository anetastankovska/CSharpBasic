using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Oop.Class09.Exercises.Models
{
    public class Movie
    {
        public string Title { get; set; }
        public Genre Genre { get; set; }
        public int Rating { get; set; }
        public int TicketPrice { get; set; }

        public Movie(string title, Genre genre, int rating)
        {
            Title = title;
            Genre = genre;
            if(rating < 1 || rating > 10)
            {
                throw new Exception("The number is not correct");
            }
            Rating = rating;
            TicketPrice = 5 * rating;
        }

        
    }
}
