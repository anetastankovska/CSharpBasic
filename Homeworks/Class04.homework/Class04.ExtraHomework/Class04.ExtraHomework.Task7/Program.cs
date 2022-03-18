using System;

//Task 7:
//Create a function that calculates the result of raising an integer to another integer (eg 5 raised to 3 = 53 = 5 × 5 × 5 = 125).

namespace Class04.ExtraHomework.Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            bool validNumber = false;
            bool validExponent = false;
            int parsedNumber = 0;
            int parsedExponent = 0;

            while (!validNumber)
            {
                Console.WriteLine("Enter a number: ");
                string number = Console.ReadLine();
                bool isValidNumber = int.TryParse(number, out parsedNumber);
                if (isValidNumber)
                {
                    validNumber = true;
                }
                else
                {
                    Console.WriteLine("Enter a valid number!");
                    continue;
                }
            }

            while (!validExponent)
            {
                Console.WriteLine("Enter an exponent: ");
                string exponent = Console.ReadLine();
                bool isValidExponent = int.TryParse(exponent, out parsedExponent);
                if (isValidExponent)
                {
                    validExponent = true;
                }
                else
                {
                    Console.WriteLine("Enter a valid exponent!");
                    continue;
                }
            }
            double calculateExponent = ToExponent1(parsedNumber, parsedExponent);
            Console.WriteLine("The result is {0}", calculateExponent);
        }

        //First way
        public static long ToExponent(int num, int exp)
        {
            long result = 1;
            for (int i = 0; i < exp; i++)
            {
                result *= num;
            }
            return result;
        }

        //Second way
        public static long ToExponent1(int num, int exp)
        {
            long result = (long) Math.Pow(num, exp);
            return result;
        }
    }
}
