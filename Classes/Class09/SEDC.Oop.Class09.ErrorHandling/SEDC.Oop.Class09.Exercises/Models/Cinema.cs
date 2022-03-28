using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Oop.Class09.Exercises.Models
{
    public class Cinema
    {
        public string Name { get; set; }
        public int Halls { get; set; }
        public List<Movie> Movies { get; set; }

        public Cinema(string name, int halls, List<Movie> movies)
        {
            Name = name;
            Halls = halls;
            Movies = movies;
        }

        public void MoviePlaying(Movie movie)
        {
            Console.WriteLine($"Watching {movie.Title}.");
        }
    }

    
}
