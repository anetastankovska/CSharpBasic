using SEDC.Oop.Class05.Exercises.Models;
using System;

namespace SEDC.Oop.Class05.Exercises
{
    class Program
    {
        static void Main(string[] args)
        {

            Human human = new Human("Trajan", "Stevkovski", 33);
            HumanInfoResult result = human.GetHumanInfo();

            Console.WriteLine(string.Format("{0} {1}", result.FullName, result.Age));

            Console.ReadLine();
        }
    }
}
