using SEDC.Oop.Class09.Exercises.Models;
using System;
using System.Collections;
using System.Collections.Generic;

namespace SEDC.Oop.Class09.Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
            Movie harryPotter = new Movie("Harry Potter", Genre.SciFi, 5);

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            List<Movie> movieList = new List<Movie>() {
                

            };

            //Cinema newCinema = new Cinema("Cineplexx", 7, )

            Console.ReadLine();
        }

    }
}
