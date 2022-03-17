using System;

//Task 3:
//Create a two functions that calculate the amount of numeric digits and vowels(samoglaski) that a text string contains. It will accept one parameter parameter: the string that we want to search,

//Function 1 should return the number of digits,
//Function 2 should return the number of vowels.
//Do not name them function1 and 2 :)

namespace Class04.ExtraHomework.Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string you want to test for vowels and digits");

            string userInput = Console.ReadLine();

            int numberOfDigits = CountDigits(userInput);
            Console.WriteLine("The number of digits in the given string is {0}.", numberOfDigits);

            int numberOfVowels = CountVowels(userInput);
            Console.WriteLine("The number of vowels in the given string is {0}", numberOfVowels);

            Console.ReadLine();
        }

        public static int CountDigits(string testString)
        {
            int counter = 0;
            char[] charArr = testString.ToCharArray();
            foreach(char character in charArr)
            {
                if (char.IsDigit(character))
                {
                    counter++;
                }
            }
            return counter;
        }

        public static int CountVowels(string testString)
        {
            int counter = 0;
            char[] charArr = testString.ToCharArray();

            foreach(char character in charArr)
            {
                char loweredChar = char.ToLower(character);
                switch (loweredChar)
                {
                    case 'a':
                    case 'e':
                    case 'i':
                    case 'o':
                    case 'u':
                        counter++;
                        break;
                        
                    default:
                        break;
                }
            }
            return counter;
        }

    }
}
