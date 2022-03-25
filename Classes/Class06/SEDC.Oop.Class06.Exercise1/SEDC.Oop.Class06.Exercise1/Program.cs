using SEDC.Oop.Class06.Exercise1.Models;
using System;

namespace SEDC.Oop.Class06.Exercise1

//    Task 1
//Create a method called NumberStats that accepts a number.This method should:

//Find out if the number is negative or positive

//Find out if the number is odd or even

//Find out if the number is decimal or integer

//After finding all the stats it should print them like this:

//Stats for number: 25

//Positive
//Integer
//Odd
//The number should be entered in the console by the user.

//Bonus: Validate if the user is entering a number

//Bonus: Ask the user to press Y to try again or X to exit

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
