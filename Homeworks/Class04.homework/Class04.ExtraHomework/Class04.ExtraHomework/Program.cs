using System;

namespace Class04.ExtraHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a word to check if it is palindrome");
            string word = Console.ReadLine();

            if (!isPalindrome(word))
            {
                Console.WriteLine($"The word {word} is NOT palindrome");
            }
            else
            {
                Console.WriteLine($"The word {word} is palindrome");
            }

            Console.ReadLine();
        }

        public static bool isPalindrome(string str)
        {
            char[] arr = str.ToLower().ToCharArray();
            for (int i = 0; i < arr.Length/2; i++)
            {
                if (!(arr[i] == arr[arr.Length - 1 - i])) 
                {
                    return false;
                }
            }
            return true;
        }

        public static bool isPalindrome1(string str)
        {
            char[] arr = str.ToLower().ToCharArray();
            char[] reversedArr = new char[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                reversedArr[i] = arr[arr.Length - 1 - i];
            }
            string joinedReversedArr = String.Join("", reversedArr).ToLower();
            if(str == joinedReversedArr)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool isPalindrome2(string str)
        {
            char[] arr = str.ToLower().ToCharArray();
            Array.Reverse(arr);
            string reversed = String.Join("", arr).ToLower();

            if (str == reversed)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
