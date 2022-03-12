using System;

namespace SEDC.Oop.Class03.Exercises.Arrays
{
    class Program
    {
        static void Main(string[] args)
        {

            // Task 1
            //string[] wordsArr = new string[5];

            //float[] decimalArr = new float[5];

            //char[] charArr = new char[5];

            //bool[] boolArr = new bool[5];

            //int[][] arrOfArrays = new int[2][];

            //arrOfArrays[0] = new int[2];
            //arrOfArrays[1] = new int[2];


            // Task 2
            //int[] arrOfIntegers = new int[5];

            //int[] sumArr = new int[5];
            //int sumNum = 0;
            //for(int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine($"Please enter input {i + 1}");
            //    string inputNum = Console.ReadLine();
            //    bool isValidInput = int.TryParse(inputNum, out int parsedInput);
            //    if (!isValidInput)
            //    {
            //        Console.WriteLine("The input is invalid!");
            //        return;
            //    }
            //    sumArr[i] = parsedInput;
            //    sumNum += parsedInput;
            //}

            //Console.WriteLine("The result is " + sumNum);


            // Task 3

            string[] names = new string[] { };

            int counter = 0;
            string response = "Y";

            while (response == "Y") { 
            
                Console.WriteLine("Enter a name:");
                string inputName = Console.ReadLine();
                Array.Resize(ref names, names.Length + 1);
                names[counter] = inputName;
                counter++;

                Console.WriteLine("Do you want to continue? (Y/N)");
                if (response == "N")
                {
                    break;
                }
                Console.WriteLine(names);


            }


        }

    }
}
