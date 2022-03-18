using System;

//Task 5:
//Create a function to check whether a character is an alphabet or not and if so go to check for the case.

namespace Class04.ExtraHomework.Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter a string to check for letters and their case:");
            //string userInput = Console.ReadLine();

            //CheckAlphaAndCase(userInput);

            //CheckAlphaAndCase2(userInput);


            while (true)
            {
                Console.Write("Enter a character:");
                ConsoleKeyInfo userInput = Console.ReadKey();

                if (userInput.Key == ConsoleKey.Escape)
                {
                    break;
                }
                Console.WriteLine($" {checkIfCharIsAlphaAndCase(userInput.KeyChar)}");
            }
        }

        //This is the first way by printing the result for each char in cosole
        public static void CheckAlphaAndCase(string testString)
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
                else
                {
                    Console.WriteLine("The character {0} is not an alphabetic", character);
                }  
            }
        }

        //By separating the character check in one method and looping through the array of chars 
        public static string checkIfCharIsAlphaAndCase(char testChar)
        {
            string result = string.Empty;
            if (char.IsLetter(testChar))
            {
                if (char.IsUpper(testChar))
                {
                    result = string.Format("The char {0} is uppercase", testChar);
                }
                else
                {
                    result = string.Format("The char {0} is lowercase", testChar);
                }
            }
            else
            {
            result = string.Format("The char {0} is not an alphabetic", testChar);
            }
            return result;
        }

        public static void CheckAlphaAndCase2(string testString)
        {
            char[] charArr = testString.ToCharArray();    
            foreach(char character in charArr)
            {
                Console.WriteLine(checkIfCharIsAlphaAndCase(character));
            }
        }

    }
}
