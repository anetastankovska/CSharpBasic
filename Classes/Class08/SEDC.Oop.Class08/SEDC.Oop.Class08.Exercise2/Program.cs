using System;
using System.Collections;
using System.Collections.Generic;

namespace SEDC.Oop.Class08.Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Song> songs = new List<Song>
            {
                new Song("Wind of change", 5, Genres.Rock),
                new Song("Enter Sandman", 4, Genres.Techno)
            };

            Person ane = new Person(10, "Aneta", "Stankovska", 30, Genres.Hip_Hop, songs);
            Console.WriteLine(ane.FirstName);
            ane.GetFavouriteSongs();

            Console.ReadLine();
        }


    }
}
