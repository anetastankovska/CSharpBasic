using System;

//Task 5:
//Create a function to check whether a character is an alphabet or not and if so go to check for the case.

namespace Class04.ExtraHomework.Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string to check for letters and their case:");
            string userInput = Console.ReadLine();

            CheckAlphaandCase(userInput);
        }


        public static void CheckAlphaandCase(string testString)
        {
            char[] charArr = testString.ToCharArray();
            foreach (char character in charArr)
            {
                if (char.IsLetter(character))
                {
                    if (char.IsUpper(character))
                    {
                        Console.WriteLine("The character {0} is UPPERCASE", character);
                    }
                    else
                    {
                        Console.WriteLine("The character {0} is lowercase", character);
                    }
                }
                Console.WriteLine("The character {0} is not an alphabet", character);
            }

        }
    }
}
