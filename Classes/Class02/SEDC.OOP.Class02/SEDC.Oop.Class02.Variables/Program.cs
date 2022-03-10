
using System;

namespace SEDC.Oop.Class02.Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello SEDC!");

            // let a = 3; (in JavaScript)
            // Brojki
            int number = 3;
            number = 123456; // Cannot put big number in int
            long bigNumber = 12345678909874456;
            short shortNumber = 12000;
            byte smallNumber = 8;

            double doublePrecisionNumber = 12.093123;
            float singlePrecisionNumber = 123.1f;

            string str = "Trajan Stevkovski"; // double quotes
            char character = 'a'; // single quotes

            bool isSomethingTrue = false;

            DateTime currentDate = new DateTime();

            int module = 10;
            module %= 3;
            Console.WriteLine(module);


            var a = 34567;


            //Console.WriteLine("================== DATA ENTRY ================");

            //string input = Console.ReadLine();

            //Console.WriteLine("This is the input value:" + input);


            //int parsedToInteger = int.Parse(input);
            //Console.WriteLine("This is the parsed data: " + input);

            //bool paresedToBoolean = Convert.ToBoolean(input);
            //Console.WriteLine("This is the parsed input value: " + paresedToBoolean);

            //long parsedToLong = 0;
            //bool isValidIput = long.TryParse(input, out parsedToLong);

            //bool isValidIput1 = long.TryParse(input, out long parsedToLong1);
            //Console.WriteLine("Is parsing1 valid: " + isValidIput1);
            //Console.WriteLine("This is the parsed value: " + parsedToLong1);

            //Console.WriteLine("Is parsing valid: " + isValidIput);
            //Console.WriteLine("This is the parsed value: " + parsedToLong);


            //string parsedToString = parsedToLong.ToString();


            Console.WriteLine("================= BRANCHING ==================");

            string input = Console.ReadLine();

            bool isValidInteger = int.TryParse(input, out int parsedInput);

            if (isValidInteger)
            {
                Console.WriteLine("The parsed number is: " + parsedInput);
            } else
            {
                Console.WriteLine("Not valid input!");
            }

            int firstNumber = 5;
            int secondNumber = 10;
            int thirdNumber = 15;
            int fourthNumber = 20;

            if (firstNumber < secondNumber && firstNumber > thirdNumber)
            {
                Console.WriteLine("The if statement is true");
            } 
            else if (thirdNumber < fourthNumber || secondNumber > fourthNumber)
            {
                Console.WriteLine("The first else if statement is TRUE");
            } 
            else if (firstNumber < secondNumber)
            {
                Console.WriteLine("The second else is statement is TRUE");
            } 
            else if (!(firstNumber < secondNumber))
            {
                Console.WriteLine("The third else is statement is TRUE");
            }
            else
            {
                Console.WriteLine("We are in else");
            }


            Console.WriteLine("====== SWITCH ======");

            int someNumber = 3;

            switch (someNumber)
            {
                case 1:
                    break;
                // case 'a':
                // break;
                // case "Something":
                // break;
                case 2:
                    Console.WriteLine("We are at case 2");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("We are at case 3, 4, 5");
                    break;
                default:
                    Console.WriteLine("If non of the cases is executed I'm always executed");
                    break;
            }

            Console.WriteLine();



        }
    }
}
