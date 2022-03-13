using System;
//Task 1
//Make a console application called SumOfEven. Inside it create an array of 6 integers. Get numbers from the input, find and print the sum of the even numbers from the array:

//Test Data:
//Enter integer no.1:
//4
//Enter integer no.1:
//3
//Enter integer no.1:
//7
//Enter integer no.1:
//3
//Enter integer no.1:
//2
//Enter integer no.1:
//8
//Expected Output:
//The result is: 14


//Task 2
//Make a new console application called StudentGroup
//Make 2 arrays called studentsG1 and studentsG2 and fill them with 5 student names.
//Get a number from the console between 1 and 2 and print the students from that group in the console.
//Ex: studentsG1["Zdravko", "Petko", "Stanko", "Branko", "Trajko"]
//Test Data:
//Enter student group: (there are 1 and 2 )
//1
//Expected Output:
//The Students in G1 are:
//Zdravko
//Petko
//Stanko
//Branko
//Trajko

namespace Cllass03.homework
{
    class Program
    {
        // Task 1
        public static void SumOfEven()
        {
            int[] numbers = new int[6];
            int sumOfEvenNumbers = 0;

            string response = "Y";

            while (response == "Y")
            {
                Console.Clear();
                for (int i = 0; i < numbers.Length; i++)
                {
                    Console.WriteLine($"Enter integer no. {i + 1}");
                    string input = Console.ReadLine();
                    bool isValidInput = int.TryParse(input, out int parsedInput);
                    if (!isValidInput)
                    {
                        Console.WriteLine("The input is invalid!");
                        return;
                    }
                    numbers[i] = parsedInput;

                    if (parsedInput % 2 == 0)
                    {
                        sumOfEvenNumbers += parsedInput;
                    }
                }
                string joinedArr = string.Join(',', numbers);
                Console.WriteLine(joinedArr);
                Console.WriteLine($"The sum of even numbers is: {sumOfEvenNumbers}");

                Console.WriteLine("Do you want to continue? If yes, press Y, if no press N");

                response = Console.ReadLine().ToUpper();

                if (response == "N" && response != "Y")
                {
                    Console.WriteLine("Thank you for using our app!");
                } 
                else
                {
                    Console.WriteLine("Wrong command!");
                }
            }
        }


        public static void StudentGroup()
        {

            string[] group1 = { "Stefan", "Aneta", "Aleksandar", "Maja", "Kristijan" };
            string[] group2 = { "Ilija", "Marija", "Slave", "Igor", "Ana" };
            string response = "Y";

            while (response == "Y")
            {
                Console.Clear();

                Console.WriteLine("If you want to get students of group 1, enetr 1. If you want to get students from group 2, enter 2");
                string selection = Console.ReadLine();

                if (selection != "1" && selection != "2")
                {
                    Console.WriteLine("Your selection did not provide any results! Try again!");
                }
                else if (selection == "1")
                {
                    Console.WriteLine("The students in G1 are:");
                    foreach (string student in group1)
                    {
                        Console.WriteLine(student);
                    }
                }
                else if (selection == "2")
                {
                    Console.WriteLine("The students in G2 are:");
                    foreach (string student in group2)
                    {
                        Console.WriteLine(student);
                    }
                }

                Console.WriteLine("Do you want to check students for another group?");
                response = Console.ReadLine().ToUpper();

                if (response == "N" && response != "Y")
                {
                    Console.WriteLine("Thank you for using our app!");
                }
                else
                {
                    Console.WriteLine("Wrong command!");
                }

            }

        }

        static void Main(string[] args)
        {
            SumOfEven();
            //StudentGroup();
        }
    }
}
