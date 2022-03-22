using SEDC.Oop.Class06.Exercise1.Models;
using System;

namespace SEDC.Oop.Class06.Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            string repeat = "Y";

            while (repeat == "Y")
            {
                Console.WriteLine("Enter a number:");
                string input = Console.ReadLine();

                bool isValidInput = float.TryParse(input, out float parsedInput);

                Console.ReadLine();
                InfoModel infoModel1 = new InfoModel(parsedInput);
                string result = infoModel1.NumberStats();
                Console.WriteLine(result);

                Console.WriteLine("Do you want to try again? (Y/X)");
                repeat = Console.ReadLine();

                if (repeat == "X")
                {
                    Console.WriteLine("Thank you for using our app!");
                    return;
                }
            }

            

        }

        
            
        
    }
}
