using System;

//Task 4:
//Create a function to read a sentence from input and replace lowercase characters by uppercase and vice-versa.

namespace Class04.extraHomework.Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a string to reverse its case:");

            string userinput = Console.ReadLine();
            string reversed = ReverseCase(userinput);
            Console.WriteLine("the after case conversion {0}", reversed);

            Console.ReadLine();
        }

        public static string ReverseCase(string testString)
        {
            char[] charArr = testString.ToCharArray();
            for (int i = 0; i < charArr.Length; i++)
            {
                if (char.IsLetter(charArr[i]))
                {
                    charArr[i] = char.IsUpper(charArr[i]) ? char.ToLower(charArr[i]) : char.ToUpper(charArr[i]);
                }
            }
            string result = string.Join("", charArr);
            return result;
        }

    }
}
