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
                new Song("Party up", 3, Genres.Hip_Hop),
                new Song("Lovestruck", 5, Genres.Techno),
                new Song("Nocturne in C-sharp minor", 10, Genres.Classical),
                new Song("Blue", 4, Genres.Techno)
            };

            List<Person> people = new List<Person>
            {
                new Person(1, "Jerry", "B", 19, Genres.Classical, new List<Song>()),
                new Person(2, "Maria", "D", 28, Genres.Hip_Hop, new List<Song>()),
                new Person(3, "Jane", "F", 35, Genres.Techno, new List<Song>()),
                new Person(4, "Stefan", "I", 33, Genres.Rock, new List<Song>())
            };

            static void AddSongsToJerryList(Person person)
            {
                person.
            }
           

            Console.ReadLine();
        }


    }
}
