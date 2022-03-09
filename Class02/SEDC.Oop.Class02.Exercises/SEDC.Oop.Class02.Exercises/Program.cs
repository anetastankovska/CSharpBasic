using System;

namespace SEDC.Oop.Class02.Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            double doubleOne = 9.09569823;
            double doubleTwo = 3.12458792;

            double resultDouble = doubleOne / doubleTwo;
            Console.WriteLine(resultDouble);

            int intOne = 25;
            int intTwo = 7;

            int resultInt = intOne / intTwo;
            Console.WriteLine(resultInt);


            string strOne = "Aneta";
            string strTwo = "Stankovska";

            string resultStr = strOne + strTwo;
            Console.WriteLine(resultStr);

            string strNumOne = "9";
            string strNumTwo = "3";

            string resultStrTwo = strNumOne + strNumTwo;
            Console.WriteLine(resultStrTwo);


            int integerOne = 9;
            string stringOne = "Ane";

            string resultIntAndStr = integerOne + stringOne;
            Console.WriteLine(resultIntAndStr);


            int n = 102;
            int m = 5;
            int totalSms = n / m;
            Console.WriteLine(totalSms);

            Console.WriteLine("=======================");
            int applesPerBranch = 8;
            int applesPerBasket = 5;

            float result = 12 * applesPerBranch / applesPerBasket;
            Console.WriteLine(result);

            Console.WriteLine("=======================================================");

            string inputOne = Console.ReadLine();
            string inputTwo = Console.ReadLine();

            bool isValidIntegerOne = int.TryParse(inputOne, out int parsedInputOne);
            bool isValidIntegerTwo = int.TryParse(inputTwo, out int parsedInputTwo);

            if (isValidIntegerOne && isValidIntegerTwo)
            {



                Console.WriteLine(parsedInputOne);
                Console.WriteLine(parsedInputTwo);


                if (parsedInputOne > parsedInputTwo)
                {
                    Console.WriteLine("The first input is larger than second input");
                }
                else if (parsedInputOne < parsedInputTwo)
                {
                    Console.WriteLine("The second input is greater than the first");
                }
                else
                {
                    Console.WriteLine("They are equal");
                }

                if (parsedInputOne % 2 == 0)
                {
                    Console.WriteLine("The first input is even");
                }
                else if (parsedInputOne % 2 != 0)
                {
                    Console.WriteLine("The first input is odd");
                }


                if (parsedInputTwo % 2 == 0)
                {
                    Console.WriteLine("The second input is even");
                }
                else if (parsedInputTwo % 2 != 0)
                {
                    Console.WriteLine("The second input is odd");
                }

                string inputNumFirst = Console.ReadLine();

                bool isValidInput = int.TryParse(inputNumFirst, out int parsedInput);

                switch (parsedInput)
                {
                    case 1:
                        Console.WriteLine("You got a new car!");
                        break;
                    case 2:
                        Console.WriteLine("You got a");
                        break;
                    case 3:
                        Console.WriteLine("You got a");
                        break;
                    default:
                        Console.WriteLine("");
                        break;
                }



            }

            
            
        }
    }
}
