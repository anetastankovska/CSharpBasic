using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Oop.Class07.Inheritance.Models
{
    public class Animal
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Race { get; set; }

        public Animal()
        {
            Console.WriteLine("A new instance of animal has been created. This is the animal constructor");
        }

        public Animal(string name, string type, string race)
        {
            Name = name;
            Type = type;
            Race = race;
            Console.WriteLine("A new instance of animal has been created. This is the animal constructor with parameters");
        }

        public virtual void Eat()
        {
            Console.WriteLine($"The {Type} animal named {Name} is eating");
        }
    }
}
