using System;
using SEDC.Oop.Class05.Classes.models;

namespace SEDC.Oop.Class05.Classes
{
    class Program
    {
        static void Main(string[] args)
        {

            Person person = new Person();
            person.Age = 33;
            person.Name = "Trajan";
            person.Talk("Hello World!");

            Person person1 = new Person()
            {
                Age = 22,
                Name = "Vlatko"
            };

            person1.Talk("Hello students!");
            
            Console.ReadLine();
        }
    }
}
