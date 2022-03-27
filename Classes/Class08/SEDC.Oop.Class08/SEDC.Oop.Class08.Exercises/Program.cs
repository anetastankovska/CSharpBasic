using System;
using System.Collections;
using System.Collections.Generic;

namespace SEDC.Oop.Class08.Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Exercise 1
            Dictionary<string, int> phoneBook = new Dictionary<string, int>
            {
                { "Aneta", 123123 },
                { "Aleksandar", 456456 },
                { "Stefan", 321321 },
                { "Igor", 234567 }
            };


            Console.WriteLine("Enter a name to search for their number");
            string name = Console.ReadLine();

            foreach (KeyValuePair<string, int> keyValue in phoneBook)
            {
                if (name == keyValue.Key)
                {
                    Console.WriteLine("The number is: " + keyValue.Value);
                    return;
                }
            }
            Console.WriteLine("Error");

            #endregion

            #region Exercise2



            #endregion

            Console.ReadLine();
        }

        

    }
}
