using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Oop.Class08.Exercise2
{
    public class Song
    {
        public string Title { get; set; }
        public int Length { get; set; }
        public Genres Genre { get; set; }
        

        public Song(string title, int length, Genres genre)
        {
            Title = title;
            Length = length;
            Genre = genre;
        }
    }

}
