using System;

namespace SEDC.Oop.Class04
{
    class Program
    {
        static void Main(string[] args)
        {

            SayHello();
            int result = Sum(6, 9);
            Console.WriteLine(result);
            string strResult = WelcomeUser("Trajan", 33, true);
            Console.WriteLine(strResult);


            Console.WriteLine("Please enter first number");
            string inputOne = Console.ReadLine();
            bool isValidNumOne = int.TryParse(inputOne, out int parsedInputOne);

            Console.WriteLine("Please enter second number:");
            string inputTwo = Console.ReadLine();
            bool isValidNumTwo = int.TryParse(inputTwo, out int parsedInputTwo);

            Console.WriteLine("If you want to multiply numbers press *, if you want to subtract numbers press -");
            string choice = Console.ReadLine();
            if (choice == "*")
            {
                MultipyNum(parsedInputOne, parsedInputTwo);
            }
            else if (choice == "-")
            {
                SubtractNum(parsedInputOne, parsedInputTwo);
            }

            Console.ReadLine();
        }

        static void SayHello()
        {
            Console.WriteLine("Hello SEDC!");
        }

        static int Sum(int a, int b)
        {
            int result = a + b;
            return result;
        }

        internal static string WelcomeUser(string username, int age, bool shouldBeColored)
        {
            if (shouldBeColored)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
            }

            string str = string.Empty;

            if (age > 30)
            {
                str = "Welcome mr." + username;
            }
            else
            {
            str = "Welcome " + username;
            }
            return str;
        }

        public static int MultipyNum(int a, int b)
        {
            int result = a * b;
            Console.WriteLine("The result is " + result);
            return a * b;
        }

        public static int SubtractNum(int a, int b)
        {
            int result = a - b;
            Console.WriteLine("The result is " + result);
            return result;
        }

    }
}
