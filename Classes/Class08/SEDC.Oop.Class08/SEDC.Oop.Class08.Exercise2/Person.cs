using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Oop.Class08.Exercise2
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Genres FavoriteMusicType { get; set; }
        public List<Song> FavoriteSongs { get; set; }
        

        public Person(int id, string firstName, string lastName, int age, Genres genre)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            FavoriteMusicType = genre;
            FavoriteSongs = new List<Song>();
        }

        public void GetFavouriteSongs()
        {
            if(FavoriteSongs.Count == 0)
            {
                Console.WriteLine("This person hates music.");
            }
            else
            {
                foreach (Song song in FavoriteSongs)
                {
                    Console.WriteLine(song.Title);
                }
            }
        }

    }
}
