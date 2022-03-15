using System;

namespace SEDC.Oop.Class04.DateTimes.Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime currentDateTime = DateTime.Now;
            DateTime add3days = currentDateTime.AddDays(3);
            DateTime add1Month = currentDateTime.AddMonths(1);
            DateTime add1monthAnd3Days = currentDateTime.AddMonths(1).AddDays(3);
            DateTime subtract1Yearand2months = currentDateTime.AddYears(-1).AddMonths(-2);
            string currentMonth = string.Format("Today is month {0:MM} of the year", currentDateTime);
            string currentDay = string.Format("Today is day {0:dd} of the month", currentDateTime);

            Console.WriteLine(currentDateTime);
            Console.WriteLine(add3days);
            Console.WriteLine(add1Month);
            Console.WriteLine(add1monthAnd3Days);
            Console.WriteLine(subtract1Yearand2months);
            Console.WriteLine(currentMonth);
            Console.WriteLine(currentDay);



            Console.ReadLine();

        }
    }
}
