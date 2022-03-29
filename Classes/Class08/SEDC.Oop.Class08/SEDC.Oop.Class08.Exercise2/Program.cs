using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace SEDC.Oop.Class08.Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Song> songs = new List<Song>
            {
                new Song("Changes", 4, Genres.Hip_Hop),
                new Song("Wind of change", 5, Genres.Rock),
                new Song("Swan lake", 9, Genres.Classical),
                new Song("Sweet Child O'Mine", 5, Genres.Rock),
                new Song("Someday", 4, Genres.Techno),
                new Song("Ode to joy", 17, Genres.Classical),
                new Song("Party up", 2, Genres.Hip_Hop),
                new Song("Lovestruck", 5, Genres.Techno),
                new Song("Nocturne in C-sharp minor", 10, Genres.Classical),
                new Song("Blue", 4, Genres.Techno)
            };

            List<Person> people = new List<Person>
            {
                new Person(1, "Jerry", "B", 19, Genres.Classical),
                new Person(2, "Maria", "D", 28, Genres.Hip_Hop),
                new Person(3, "Jane", "F", 35, Genres.Techno),
                new Person(4, "Stefan", "I", 33, Genres.Rock)
            };

            Person jerry = people.FirstOrDefault(a => a.FirstName == "Jerry");
            List<Song> songsForJerrysList = songs.Where(a => a.Title.StartsWith("B")).ToList();
            jerry.FavoriteSongs = songsForJerrysList;

            Person maria = people.FirstOrDefault(a => a.FirstName == "Maria");
            List<Song> songsForMariasList = songs.Where(a => a.Length > 6).ToList();
            maria.FavoriteSongs = songsForMariasList;

            Person jane = people.FirstOrDefault(a => a.FirstName == "Jane");
            List<Song> sonsgForJanesList = songs.Where(a => a.Genre == Genres.Rock).ToList();
            jane.FavoriteSongs = sonsgForJanesList;

            Person stefan = people.FirstOrDefault(a => a.FirstName == "Stefan");
            List<Song> songsForStefansList = songs.Where(a => a.Length < 3 && a.Genre == Genres.Hip_Hop).ToList();
            stefan.FavoriteSongs = songsForStefansList;

            List<Person> newListOfPeople = people.Where(a => a.FavoriteSongs.Count >=3).ToList();

            Console.ReadLine();
        }


    }
}
