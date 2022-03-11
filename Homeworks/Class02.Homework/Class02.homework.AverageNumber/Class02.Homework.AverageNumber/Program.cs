using System;

namespace Class02.Homework.AverageNumber
{
    class Program
    {

        public static void SimpleAverage()
        {
            string repeat = "y";

            while (repeat == "y")
            {
                Console.Clear();
                Console.WriteLine("Enter the first number");
                string firstInput = Console.ReadLine();
                // bool isValidFirstInput = float.TryParse(firstInput, out float parsedFirstInput); 

                if (!float.TryParse(firstInput, out float parsedFirstInput))
                {
                    Console.WriteLine("The input is invalid!");
                    return;
                }

                Console.WriteLine("Enter the second input");
                string secondInput = Console.ReadLine();
                // bool isValidSecondInput = float.TryParse(secondInput, out float parsedSecondInput);

                if (!float.TryParse(secondInput, out float parsedSecondInput))
                {
                    Console.WriteLine("The input is invalid!");
                    return;
                }

                Console.WriteLine("Enter the third input");
                string thirdInput = Console.ReadLine();
                // bool isValidThirdInput = float.TryParse(thirdInput, out float parsedThirdInput);

                if (!float.TryParse(thirdInput, out float parsedThirdInput))
                {
                    Console.WriteLine("The input is invalid!");
                    return;
                }

                Console.WriteLine("Enter the fourth input");
                string fourthInput = Console.ReadLine();
                //bool isValidFourthInput = float.TryParse(fourthInput, out float parsedFourthInput);

                if (!float.TryParse(fourthInput, out float parsedFourthInput))
                {
                    Console.WriteLine("The input is invalid!");
                    return;
                }

                double result = (parsedFirstInput + parsedSecondInput + parsedThirdInput + parsedFourthInput) / 4;
                Console.WriteLine($"The average of {parsedFirstInput}, {parsedSecondInput}, {parsedThirdInput} and {parsedFourthInput} is {result}");
                break;
            }

            Console.WriteLine("Do you want to try again? (y/n)");
            repeat = Console.ReadLine();

            if (repeat == "n")
            {
                return;
            }
        }



        public static void AverageWithFor()
        {
            string repeat = "y";

            while (repeat == "y")
            {
                Console.Clear();
                float sumNum = 0;
                string resultStr = "The average of ";
                for (int i = 0; i < 4; i++)
                {
                    Console.WriteLine($"Please enter input {i + 1}");
                    string inputNum = Console.ReadLine();
                    bool isValidInput = float.TryParse(inputNum, out float parsedInput);
                    if (!isValidInput)
                    {
                        Console.WriteLine("The input is invalid!");
                        return;
                    }
                    resultStr += $"{inputNum} ";
                    sumNum += parsedInput;
                }
                float result = sumNum / 4;
                //Console.WriteLine($"The result is {result}");
                Console.WriteLine($"{resultStr} is {result}");
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
            AverageWithFor();
            //SimpleAverage();
        }
    }
}
