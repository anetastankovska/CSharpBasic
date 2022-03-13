using System;

namespace SEDC.Oop.class02.Exercises
{
    class Program
    {

        public static void PrintNumbersAscAndDecs()
        {
            //Get an input number from the console. Print all numbers from 1 to that number
            //Get another input number from the console. Print all numbers from that number to 1

            Console.WriteLine("Eneter the first number:");
            string inputone = Console.ReadLine();

            bool isvalidinputOne = int.TryParse(inputone, out int parsedinputone);

            if (!isvalidinputOne)
            {
                Console.WriteLine("Enter a valid integer!");
                return;
            }

            for (int i = 0; i <= parsedinputone; i++)
            {
                Console.WriteLine(i);
            }


            Console.WriteLine("Enter the second number:");
            string inputTwo = Console.ReadLine();

            bool isValidInputTwo = int.TryParse(inputTwo, out int parsedInputTwo);

            if (!isValidInputTwo)
            {
                Console.WriteLine("Enter a valid integer!");
            }
            for (int i = parsedInputTwo; i > 0; i--)
            {
                Console.WriteLine(i);
            }
        }

        public static void PrintOddAndEvenNumbers()
        {
            //Get an input number from the console. Print all even numbers starting from 2
            //Get another input number  from the console. Print all odd numbers  starting from 1

            Console.WriteLine("Eneter a first number:");
            string inputOne = Console.ReadLine();

            bool isValidInputOne = int.TryParse(inputOne, out int parsedInputOne);
            if (!isValidInputOne)
            {
                Console.WriteLine("Enter a valid integer!");
                return;
            }

            for (int i = 2; i <= parsedInputOne; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine("Enter a second number");
            string inputTwo = Console.ReadLine();

            bool isValidInputTwo = int.TryParse(inputTwo, out int parsedInputTwo);

            if (!isValidInputTwo)
            {
                Console.WriteLine("Enter a valid integer!");
                return;
            }

            for (int i = 0; i <= parsedInputTwo; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }


        public static void PruntToHundred()
        {

            //Get an input from the console. Print all numbers from 1 to that number. Don’t print numbers that can be divided by 3 or 7
            //If the number gets to 100 print a message: The limit is reached and stop counting

            Console.WriteLine("Enter a number:");
            string input = Console.ReadLine();

            bool isValidInput = int.TryParse(input, out int parsedInput);

            for (int i = 0; i < parsedInput; i++)
            {
                if (i > 100)
                {
                    Console.WriteLine("The limit is reached. You cannot entern numbers greater than 100");
                    break;
                }
                if (i % 3 != 0 && i % 7 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        private static void FizzBuzz()
        {

            //Write a program that prints the numbers from 1 to 100.
            //But for multiples of three print “Fizz” instead of the number and for the multiples of five print “Buzz”.
            //For numbers which are multiples of both three and five print “FizzBuzz

            for (int i = 0; i < 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                    continue;
                }
                if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                    continue;
                }
                if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                    continue;
                }
                Console.WriteLine(i);
            }
        }

        static void Main(string[] args)
        {
            //PrintNumbersAscAndDesc();

            //PrintOddAndEvenNumbers();

            //PruntToHundred();

            //FizzBuzz();
        }
    }
}
