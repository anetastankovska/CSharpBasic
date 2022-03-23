using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Oop.Class07.Inheritance.Models
{
    class Dog : Animal
    {
        public bool IsPlayful { get; set; }

        public Dog()
        {
            Console.WriteLine("A new instance of dog has been created. This is the dog constructor");
        }

        public Dog(string name, string type)
            : base(name, type, "Doggy")
        {
            IsPlayful = false;
            Console.WriteLine("A new instance of dog has been created. This is the dog constructor with parameters");
        }

        public void DogEat()
        {
            Console.WriteLine("Dog eats food");
            base.Eat();
        }
    }
}
