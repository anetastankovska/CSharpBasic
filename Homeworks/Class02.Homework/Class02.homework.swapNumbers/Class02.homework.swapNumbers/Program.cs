using System;

namespace Class02.homework.swapNumbers
{
    class Program
    {
        public static void SwapNumbers()
        {
            string repeat = "y";

            while (repeat == "y")
            {
                Console.WriteLine("Enter the first number");
                string firstInput = Console.ReadLine();
                if (!float.TryParse(firstInput, out float parsedFirstInput))
                {
                    Console.WriteLine("Please enter a valid number to continue!");
                    return;
                }

                Console.WriteLine("Enter the second number:");
                string secondInput = Console.ReadLine();
                if (!float.TryParse(secondInput, out float parsedSecondInput))
                {
                    Console.WriteLine("Please enter a valid number to continue!");
                    return;
                }

                float temp = parsedFirstInput;
                parsedFirstInput = parsedSecondInput;
                parsedSecondInput = temp;

                Console.WriteLine($"After swapping: \n First Number: {parsedFirstInput} \n Second Number: {parsedSecondInput}");
                break;
            }

            Console.WriteLine("Do you want to try again? (y/n)");
            repeat = Console.ReadLine();

            if (repeat == "n")
            {
                return;
            }

        }

        // If we don't care whether the inputed values are numbers or not, we can siply treat them as strings and swap the inputed values as strings

        public static void SwapInputedValues()
        {
            string repeat = "y";

            while (repeat == "y")
            {
                Console.Clear();
                Console.WriteLine("Enter the first input:");
                string firstInput = Console.ReadLine();

                Console.WriteLine("Enter the second input:");
                string secondInput = Console.ReadLine();

                string temp = firstInput;
                firstInput = secondInput;
                secondInput = temp;

                Console.WriteLine($"After swapping: \n First input: {firstInput} \n Second input: {secondInput}");
                break;
            }


            Console.WriteLine("Do you want to try again? (y/n)");
            repeat = Console.ReadLine();

            if (repeat == "n")
            {
                return;
            }
        }

        static void Main(string[] args)
        {
            SwapNumbers();
            //SwapInputedValues();
        }
    }
}

