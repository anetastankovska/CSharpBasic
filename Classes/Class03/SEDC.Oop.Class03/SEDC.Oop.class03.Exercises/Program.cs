using System;

namespace SEDC.Oop.class02.Exercises
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("Eneter the first number:");
            //string inputOne = Console.ReadLine();

            //bool isValidInputOne = int.TryParse(inputOne, out int parsedInputOne);

            //for(int i = 0; i <= parsedInputOne; i++)
            //{
            //    Console.WriteLine(i);
            //}


            //Console.WriteLine("Enter the second number:");
            //string inputTwo = Console.ReadLine();

            //bool isValidInputTwo = int.TryParse(inputTwo, out int parsedInputTwo);
            //for(int i = parsedInputTwo; i > 0; i--)
            //{
            //    Console.WriteLine(i);
            //}


            //Console.WriteLine("Eneter a first number:");
            //string inputOne = Console.ReadLine();

            //bool isValidInputOne = int.TryParse(inputOne, out int parsedInputOne);

            //for(int i = 2; i <= parsedInputOne; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //Console.WriteLine("Enter a second number");
            //string inputTwo = Console.ReadLine();

            //bool isValidInputTwo = int.TryParse(inputTwo, out int parsedInputTwo);

            //for(int i = 0; i <= parsedInputTwo; i++)
            //{
            //    if (i %2 != 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}



            //Console.WriteLine("Enter a number:");
            //string input = Console.ReadLine();

            //bool isValidInput = int.TryParse(input, out int parsedInput);

            //for(int i = 0; i < parsedInput; i++)
            //{
            //    if(i > 100)
            //    {
            //        Console.WriteLine("You cannot entern numbers greater than 100");
            //        break;
            //    }
            //    if (i % 3 != 0 && i % 7 != 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}


            Console.WriteLine("FIZZ/BUZZ task");
            for(int i = 0; i < 100; i++)
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
    }
}
