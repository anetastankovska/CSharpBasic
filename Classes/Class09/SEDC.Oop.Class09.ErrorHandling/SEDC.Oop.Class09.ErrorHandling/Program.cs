using SEDC.Oop.Class09.ErrorHandling.Models;
using SEDC.Oop.Class09.ErrorHandling.Services;
using System;

namespace SEDC.Oop.Class09.ErrorHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number example");
            Console.WriteLine("Enter a number:");

            //try
            //{
            //    string input = Console.ReadLine();
            //    int number = int.Parse(input);
            //    Console.WriteLine(number);
            //}
            //catch(FormatException ex)
            //{
            //    Console.WriteLine("EW ARE IN FORMAT EXEPTION");
            //    Console.WriteLine(ex.Message);
            //}
            //catch (ArgumentException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //catch(OverflowException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //finally
            //{
            //    Console.WriteLine("I will lways be executed");
            //}


            //Console.WriteLine("Enter the letter a or b.");
            //try
            //{
            //    string inputStr = Console.ReadLine();
            //    if(inputStr == "a" || inputStr == "b")
            //    {
            //        Console.WriteLine("Congratulations! You enterd a or b");
            //    }
            //    else
            //    {
            //        throw new Exception("That is not a or b. Sorry!");
            //    }
            //}
            //catch(Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //    //Console.WriteLine(ex.InnerException.Message);
            //}

            //try
            //{
            //    string consoleInput = Console.ReadLine();
            //    int a = ParseNumber(consoleInput);
            //}
            //catch (Exception ex)
            //{

            //    Console.WriteLine(ex.Message);
            //    Console.WriteLine(ex.StackTrace);
            //}

            Console.ReadLine();

        }

        public static int ParseNumber (string input)
        {
            try
            {
                return int.Parse(input);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static void HumanServiceMainMethod()
        {
            HumanService service = new HumanService();

            foreach(Human human in service.Humans)
            {
                try
                {
                    service.PrintHumanSkills(human);
                }
                catch(Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex.Message);
                    Console.ResetColor();
                }
                
            }

        }

        
    }
}
