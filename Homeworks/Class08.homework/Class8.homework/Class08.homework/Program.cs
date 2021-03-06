using System;
using System.Collections;
using System.Collections.Generic;

//Task 1
//Give the user an option to input numbers
//After inputing each number ask them if they want to input another with a Y/N question
//Store all numbers in a QUEUE
//When the user is done adding numbers print the number in the order that the user entered them from the QUEUE

namespace Class08.homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queueOfNumbers = new Queue<int>();
            string response = "Y";
            while(response == "Y")
            {
                ValidateInteger(queueOfNumbers);
                Console.WriteLine("Do you want to add another number in the queue? Y/N");
                response = Console.ReadLine();
                if(response == "N")
                {
                    Console.WriteLine("Thank you for using our app. The numbers you entered in the queue are the following:");
                    PrintNumbersFromQueue(queueOfNumbers);
                }
            }
            Console.ReadLine();
        }


        public static int ValidateInteger (Queue<int> queue)
        {
            Console.WriteLine("Enter a number");
            
            while (true)
            {
                string userInput = Console.ReadLine();
                bool isValidInt = int.TryParse(userInput, out int parsedInt);
                if (!isValidInt)
                {
                    Console.WriteLine("The entered input cannot be converted to a valid integer. Try again!");
                }
                else {
                    queue.Enqueue(parsedInt);
                    return parsedInt;
                }
            } 
        }

        public static void PrintNumbersFromQueue(Queue<int> queue)
        {
            foreach (int num in queue)
            {
                Console.WriteLine(num);
            }
        }
    }
}
