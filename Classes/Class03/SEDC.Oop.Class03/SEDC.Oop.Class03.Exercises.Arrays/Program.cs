using System;

namespace SEDC.Oop.Class03.Exercises.Arrays
{
    class Program
    {
        public static void DeclareArrays()
        {
            //Task 4
            //Declare 5 arrays with 5 elements  in them:
            //With words▹With decimal values
            //With characters from keyboard
            //With true / false  values
            //With arrays, each holding 2 whole numbers

            string[] wordsArr = new string[5];

            float[] decimalArr = new float[5];

            char[] charArr = new char[5];

            bool[] boolArr = new bool[5];

            int[][] arrOfArrays = new int[2][];

            arrOfArrays[0] = new int[2];
            arrOfArrays[1] = new int[2];
        }


        public static void SumArrOfNumbers()
        {
            // Task 5
            //Declare a new array of integers with 5 elements.
            //Initialize the array elements with values from input.
            //Sum all the values and print the result in the console

            int[] arrOfIntegers = new int[5];

            int[] sumArr = new int[5];
            int sumNum = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Please enter input {i + 1}");
                string inputNum = Console.ReadLine();
                bool isValidInput = int.TryParse(inputNum, out int parsedInput);
                if (!isValidInput)
                {
                    Console.WriteLine("The input is invalid!");
                    return;
                }
                sumArr[i] = parsedInput;
                sumNum += parsedInput;
            }

            Console.WriteLine("The result is " + sumNum);
        }

        public static void PrintNames()
        {
            // Task 6
            //Create an array with names. Give an option to the user to enter a name from the keyboard.After entering the name put it in the array
            //Ask the user if they want to enter another name(Y / N). Do the same process over and over until the user enters N.
            //Print all the names after user enters N


            string[] names = new string[] { };

            int counter = 0;

            string response = "Y";
            while (response == "Y")
            {

                Console.WriteLine("Enter a name:");
                string inputName = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(inputName))
                {
                    break;
                }
                Array.Resize(ref names, names.Length + 1);
                names[counter] = inputName;
                counter++;
                Console.WriteLine(names.Length);

                Console.WriteLine("Do you want to enter another name? (Y/N)");
                response = Console.ReadLine().ToUpper();
                if (response == "N")
                {
                    Console.WriteLine("The names you entered are:");
                    foreach (string name in names)
                    {
                        string capitalizedName = name.Replace(name[0].ToString(), name[0].ToString().ToUpper());
                        Console.WriteLine(capitalizedName);
                    }
                    // Use join method to create string out of the array and then print names but they will be in one line
                    //Console.WriteLine(string.Join(',', names)); 
                    return;
                }
                else if (response != "N" && response != "Y")
                {
                    Console.WriteLine("Wrong key entered!");
                    Console.WriteLine($"The names you entered so far are: {string.Join(',', names)}");
                    return;
                }
            }
        }

        static void Main(string[] args)
        {
            //DeclareArrays();

            //SumArrOfNumbers();

            //PrintNames();


            //This is something i wanted to try on my own :) do not consider it
            //int[] arrOfNumbers = new int[] { 1, 2, 3, 4 };

            //for (int i = 0; i < 3; i++)
            //{
            //    arrOfNumbers = ShiftRight(arrOfNumbers);
            //}

            //Console.WriteLine(string.Join(',', arrOfNumbers));

        }


        //This is something i wanted to try on my own :) do not consider it
        public static int[] ShiftRight(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int temp = arr[i];
                arr[i] = arr[arr.Length - 1];
                arr[arr.Length - 1] = temp;
            }
            return arr;
        }

    }
}
