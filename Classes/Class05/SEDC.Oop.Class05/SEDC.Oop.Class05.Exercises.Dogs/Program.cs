using SEDC.Oop.Class05.Exercises.Dogs.models;
using System;

namespace SEDC.Oop.Class05.Exercises.Dogs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the dog's name");
            string nameInput = Console.ReadLine();

            Console.WriteLine("Enter the dog's race");
            string raceInput = Console.ReadLine();

            Console.WriteLine("Enter the dog's color");
            string colorInput = Console.ReadLine();

            Console.WriteLine("Please enter the activity of the dog. If you want the dog to eat press 'e'. If you want the dog to play, press 'p', if you want the dog to chase its tail, press 'c'.");

            string activity = Console.ReadLine();

            Dog dog = new Dog(nameInput, raceInput, colorInput);

            if(activity == "e")
            {
                dog.Eat();
            }
            else if(activity == "p")
            {
                dog.Play();
            }
            else if(activity == "c")
            {
                dog.ChaseTail();
            }




            Console.ReadLine();
        }
    }
}
