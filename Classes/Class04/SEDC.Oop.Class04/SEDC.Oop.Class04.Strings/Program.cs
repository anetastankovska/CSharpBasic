using System;

namespace SEDC.Oop.Class04.Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Trajan";

            string hello1 = "Hello " + name;
            string hello2 = string.Format("Hello {0}", name); // Hello Trajan
            string hello3 = $"Hello {name}";

            Console.WriteLine("Hello1: " + hello1);
            Console.WriteLine(string.Format("Hello2 {0}", hello2));
            Console.WriteLine($"Hello3: {hello3}");

            string path = "Check your c:\\ drive";
            string a = "We will have \"fair\" elections";
            string b = "The \\n sign means new line";

            Console.WriteLine(path);
            Console.WriteLine(a);
            Console.WriteLine(b);

            string path1 = @"Check your c:\ drive";
            string aa = @"We will have ""fair"" elections";
            string bb = @"The \n sign means new line";

            Console.WriteLine(path1);
            Console.WriteLine(aa);
            Console.WriteLine(bb);

            string filePath = @"system\windows";
            string cc = $@"Check your c:\ {filePath} drive";
            Console.WriteLine(cc);

            string myStringCurrency = string.Format("{0:C}", 105.5);
            Console.WriteLine(myStringCurrency);

            int phoneNumber = 077123123;
            string formattedNumber = string.Format("{0:0##-###-###}", phoneNumber);
            Console.WriteLine(formattedNumber);

            string formatWithMultipleStrings = string.Format("{0} {1} {2} {3} {4} {5}", "Hello", "my", "name", "is", "Trajan", ".");
            Console.WriteLine(formatWithMultipleStrings);

            string ourString = "                  We are learning c# and it is FUN and EASY, Okay maybe just FUN.              ";

            string lowerLetters = ourString.ToLower();
            Console.WriteLine(lowerLetters);

            string upperLetters = ourString.ToUpper();
            Console.WriteLine(upperLetters);

            string[] arraySplitted = ourString.Trim().Split(' ');
            Console.WriteLine("The length is: " + arraySplitted.Length);
            foreach(string word in arraySplitted)
            {
                Console.WriteLine(word);
            }

            string substring = ourString.Substring(25, 50);
            Console.WriteLine(substring);

            Console.WriteLine("=====TASK=====");

            Console.WriteLine("Enter a number");
            string userInput = Console.ReadLine();
            bool isValidInteger = int.TryParse(userInput, out int parsedInput);
            if (!isValidInteger)
            {
                Console.WriteLine("Enter a valid integer!");
            }

            Substrings(parsedInput);

            Console.ReadLine();
        }

        public static void Substrings(int num)
        {
            string myString = "Hello from SEDC Codeacademy 2021";
            if(num > myString.Length)
            {
                Console.WriteLine("The number is too large!");
                return;
            }
            string mySubstring = myString.Substring(0, num);
            Console.WriteLine(mySubstring);
            
        }


    }
}
