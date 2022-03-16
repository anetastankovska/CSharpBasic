using System;

namespace Class04.ExtraHomework.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a sequence of real numbers separated by comma");
            string userInput = Console.ReadLine();

            string[] splitedString = userInput.Split(",");
            double[] parsedArray = new double[splitedString.Length];

            for (int i = 0; i < splitedString.Length; i++)
            {
                bool isValidDouble = double.TryParse(splitedString[i], out parsedArray[i]);
                if (!isValidDouble)
                {
                    Console.WriteLine("The input is not valid!");
                    return;
                }
            }

            Console.WriteLine($"The maximum nuber of the given array is {findMax(parsedArray)}");

            double[] test = {1.4, 2.556, 56.7890, 334.56};
            double maxDouble = findMax(test);
            Console.WriteLine($"The maximum number of a given array is {maxDouble}");

            Console.WriteLine(findMax(new double[] { 1, 2, 3.89 }));

            Console.ReadLine();
        }

        public static double findMax(double[] arr)
        {
            double max = 0;

            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            return max;
        }
    }
}
