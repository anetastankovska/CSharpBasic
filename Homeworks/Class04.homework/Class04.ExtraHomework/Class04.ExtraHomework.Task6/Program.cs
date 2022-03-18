using System;

//Task 6:
//Create a function to find the number of times a substring appears in a given string.

namespace Class04.ExtraHomework.Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string strMain = Console.ReadLine();

            Console.Write("Enter a substring: ");
            string strSub = Console.ReadLine();

            //string[] strArray = strMain.Split(strSub);
            //Console.WriteLine("The number of occurences of the substring in the main string is {0}", strArray.Length -1);

            int result = OccurencesInString(strMain, strSub);
            Console.WriteLine("The number of occurences of the substring in the main string is {0}", result);

        }

        public static int OccurencesInString(string main, string sub)
        {
            int counter = 0;
            int index = -1;
            while (index < main.Length)
            {
                index = main.IndexOf(sub, ++index);
                if(index == -1)
                {
                    break;
                }
                counter++;
            }
            return counter;
        }
    }
}
