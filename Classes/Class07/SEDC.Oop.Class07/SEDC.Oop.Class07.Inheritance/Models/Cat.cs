using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Oop.Class07.Inheritance.Models
{
    class Cat : Animal
    {
        public bool IsLazy { get; set; }

        public Cat()
        {
            Console.WriteLine("A new instance of cat has been created. This is the cat constructor");
        }

        public Cat(string name, string type, string race, bool isLazy)
            : base(name, type, race)
        {
            IsLazy = isLazy;
            Console.WriteLine("A new instance of cat has been created. This is the cat constructor with parameters");
        }

        public override void Eat()
        {
            if (IsLazy)
            {
            Console.WriteLine("We need to feed the cat with a spoon");
            }
            else
            {
                Console.WriteLine("The cat is eating the food");
            }
        }
    }
    
}
