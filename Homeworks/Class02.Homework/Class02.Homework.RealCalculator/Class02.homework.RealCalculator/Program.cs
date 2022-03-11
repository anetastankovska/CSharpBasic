using System;

namespace SEDC.Oop.Class02.homework
{
    class Program
    {
        static void Main(string[] args)
        {
            string repeat = "y";

            while (repeat == "y")
            {
                Console.Clear();
                Console.WriteLine("Enter the first number:");
                string inputOne = Console.ReadLine();
                //bool isValidInputOne = int.TryParse(inputOne, out int parsedInputOne);

                if (!int.TryParse(inputOne, out int parsedInputOne))
                {
                    Console.WriteLine("Wrong input entered!");
                    return;
                }

                Console.WriteLine("Enter the second number:");
                string inputTwo = Console.ReadLine();
                //bool isValidInputTwo = int.TryParse(inputOne, out int parsedInputTwo);

                if (!int.TryParse(inputTwo, out int parsedInputTwo))
                {
                    Console.WriteLine("Wrong input entered!");
                    return;
                }

                Console.WriteLine("Enter the operator: ");
                string operatorChar = Console.ReadLine();

                switch (operatorChar)
                {
                    case "+":
                        Console.WriteLine("The expected result is: " + (parsedInputOne + parsedInputTwo));
                        break;
                    case "-":
                        Console.WriteLine("The expected result is: " + (parsedInputOne - parsedInputTwo));
                        break;
                    case "*":
                        Console.WriteLine("The expected result is: " + (parsedInputOne * parsedInputTwo));
                        break;
                    case "/":
                        if (parsedInputTwo == 0)
                        {
                            Console.WriteLine("You cannot divide by zero!");
                            break;
                        }
                        Console.WriteLine("The expected result is: " + (parsedInputOne * 1.0 / parsedInputTwo));
                        break;
                    default:
                        Console.WriteLine("Wrong operator entered!");
                        break;
                }

                Console.WriteLine("Do you want to try again? (y/n)");
                repeat = Console.ReadLine();

                if (repeat == "n")
                {
                    return;
                } 
            }


        }
    }
}
