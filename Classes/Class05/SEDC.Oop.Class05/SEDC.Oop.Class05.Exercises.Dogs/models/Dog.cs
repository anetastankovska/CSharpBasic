using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Oop.Class05.Exercises.Dogs.models
{
    public class Dog
    {
        public string Name { get; set; }
        public string Race { get; set; }
        public string Color { get; set; }

        public Dog(string name, string race, string color)
        {
            Name = name;
            Race = race;
            Color = color;
        }

        public string Eat()
        {
            string eatStr = "The dog is now eating";
            return eatStr;
        }

        public string Play()
        {
            string playStr = "The dog is now playing";
            return playStr;
        }

        public string ChaseTail()
        {
            string chaseTailStr = "The dog is now chasing the tail";
            return chaseTailStr;
        }
    }
}
