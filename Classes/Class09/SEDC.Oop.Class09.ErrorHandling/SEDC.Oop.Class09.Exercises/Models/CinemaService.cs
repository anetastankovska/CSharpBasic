using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using SEDC.Oop.Class09.Exercises.Models;



namespace SEDC.Oop.Class09.Exercises.Models
{
    public class CinemaService
    {
        public List<Cinema> cinemas { get; }

        public CinemaService()
        {
            cinemas = new List<Cinema>();
        }
        public void Main(params string[] args)
        {
            List<Movie> cineplexxMovieList = new List<Movie>()
            {
                new Movie("The Hangover", Genre.Comedy, 6),
                new Movie("Dumb and Dumber", Genre.Comedy, 5),
                new Movie("Ace Ventura", Genre.Comedy, 6),
                new Movie("Harry Potter",Genre.SciFi, 8),
                new Movie("The Lord of The Rings", Genre.SciFi, 9),
                new Movie("Interstellar", Genre.SciFi, 10),
                new Movie("Inception", Genre.SciFi, 9),
                new Movie("Saw", Genre.Horror, 7),
                new Movie("The Exorcist", Genre.Horror, 8),
                new Movie("The Nun", Genre.Horror, 7),
                new Movie("The Batman", Genre.Action, 10),
                new Movie("The Matrix Ressurections", Genre.Action, 8),
                new Movie("Mission: Impossible - Fallout", Genre.Action, 7),
                new Movie("The Shawshank Redemption", Genre.Drama, 10),
                new Movie("Schindler's List", Genre.Drama, 9),
                new Movie("The Last Samurai", Genre.Drama, 10)
            };

            List<Movie> milleniumMovieList = new List<Movie>()
            {
                new Movie("Game Night", Genre.Comedy, 5),
                new Movie("Mean Girls", Genre.Comedy, 6),
                new Movie("Red Notice", Genre.Comedy, 6),
                new Movie("Deadpool",Genre.Comedy, 9),
                new Movie("Ex Machina", Genre.SciFi, 8),
                new Movie("Looper", Genre.SciFi, 10),
                new Movie("Alien", Genre.SciFi, 9),
                new Movie("The Ring", Genre.Horror, 7),
                new Movie("The Conjuring", Genre.Horror, 8),
                new Movie("Scream", Genre.Horror, 7),
                new Movie("Die Hard", Genre.Action, 10),
                new Movie("Casino Royale", Genre.Action, 8),
                new Movie("John Wick", Genre.Action, 7),
                new Movie("Forrest Gump", Genre.Drama, 10),
                new Movie("The Godfather", Genre.Drama, 9),
                new Movie("Lady Bird", Genre.Drama, 10)
            };

            cinemas.Add(new Cinema("Cineplexx", 7, cineplexxMovieList));
            cinemas.Add(new Cinema("Kino Milenium", 4, milleniumMovieList));

            MainScreen();
        }

        public void MainScreen()
        {
            Console.WriteLine("Welcome to our cinema app.");
            Console.WriteLine("Please choose your favorite cinema below.");
            Console.WriteLine("==========================================");
            Console.WriteLine("1. Cineplexx MK");
            Console.WriteLine("2. Kino Milenium");
            Console.WriteLine("");
            Console.WriteLine("(To select the cinema you wish, press the appropriate number)");
            try
            {
                string userChoice = Console.ReadLine();
                if (userChoice == "1")
                {
                    ShowCinemaWelcomeScreen(cinemas[0]);
                }
                else if (userChoice == "2")
                {
                    ShowCinemaWelcomeScreen(cinemas[1]);
                }
                else
                {
                    throw new Exception("The number is out of range");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Thread.Sleep(2000);
                Console.Clear();
                MainScreen();
            }
        }

        public void ChooseGenreOrAllMovies(Cinema cinema)
        {
            Console.WriteLine("Please choose whether you like to see all movies or only by genre");
            Console.WriteLine("1. All movies");
            Console.WriteLine("2. By genre");
            string userChoice = Console.ReadLine();
            if (userChoice == "1")
            {
                Console.Clear();
                List<string> titles = cinema.Movies.Select(a => a.Title).ToList();
                PrintStrList(titles);
                SelectMovie(cinema.Movies, cinema);
            }
            else if (userChoice == "2")
            {
                Genre selected = SelectGenre(cinema);
                PrintMoviesByGenre(selected, cinema);
            }
            else
            {
                Console.WriteLine("The input is out of range. Choose a number again");
                ChooseGenreOrAllMovies(cinema);
            }
        }

        public void ShowCinemaWelcomeScreen(Cinema cinema)
        {
            Console.Clear();
            Console.WriteLine($"Welcome to {cinema.Name} service.");
            ChooseGenreOrAllMovies(cinema);
        }

        public void PrintStrList(List<string> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {list[i]}");
            }
        }

        public Genre SelectGenre(Cinema cinema)
        {
            Console.Clear();
            PrintGenres();
            string genreChoice = Console.ReadLine();
            if (genreChoice != "1" && genreChoice != "2" && genreChoice != "3" && genreChoice != "4" && genreChoice != "5")
            {
                Console.WriteLine("The input is out of range. Choose again");
                Thread.Sleep(2000);
                return SelectGenre(cinema);
            }
            else
            {
                Genre selected = (Genre)int.Parse(genreChoice);
                return selected;
            }
        }

        public void PrintGenres()
        {
            Console.WriteLine("Please enter a number to select a movie");
            int counter = 1;
            foreach (string genre in Enum.GetNames(typeof(Genre)))
            {
                Console.WriteLine($"{counter++}. {genre}");
            }
        }

        public void PrintMoviesByGenre(Genre genre, Cinema cinema)
        {
            List<string> moviesByGenre = cinema.Movies.Where(a => a.Genre == genre)
                                                  .Select(a => a.Title).ToList();
            List<Movie> movieObjByGenre = cinema.Movies.Where(a => a.Genre == genre).ToList();
            PrintStrList(moviesByGenre);
            SelectMovie(movieObjByGenre, cinema);
        }

        public Movie SelectMovie(List<Movie> movies, Cinema cinema)
        {
            string movieChoice = Console.ReadLine();
            bool isValidInt = int.TryParse(movieChoice, out int parsedInt);
            if (isValidInt && parsedInt <= movies.Count)
            {
                cinema.MoviePlaying(movies[parsedInt - 1]);
                return movies[parsedInt - 1];
            }
            else
            {
                Console.WriteLine("The input is not in range. Please try again");
                Thread.Sleep(2000);
                return SelectMovie(movies,cinema);
            }

        }
        
    }
}