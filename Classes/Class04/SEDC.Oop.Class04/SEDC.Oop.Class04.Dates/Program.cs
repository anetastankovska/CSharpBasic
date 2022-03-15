using System;

namespace SEDC.Oop.Class04.Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date = new DateTime();
            Console.WriteLine(date);

            DateTime customDate = new DateTime(1992, 10, 15);
            Console.WriteLine(customDate);

            string date1 = "12.15.2012";
            string date11 = "15.12.2012";
            string date12 = "2012.12.15";
            string date2 = "12/15/2012";
            string date3 = "12/15/12";
            string date4 = "dec.15.12";
            string date5 = "15-12.2012";

            //DateTime convertedDate1 = DateTime.Parse(date1);
            DateTime convertedDate11 = DateTime.Parse(date11);
            DateTime convertedDate12 = DateTime.Parse(date12);
            //DateTime convertedDate2 = DateTime.Parse(date2);
            //DateTime convertedDate3 = DateTime.Parse(date3);
            DateTime convertedDate4 = DateTime.Parse(date4);
            DateTime convertedDate5 = DateTime.Parse(date5);
            //Console.WriteLine(convertedDate1);
            //Console.WriteLine(convertedDate2);
            //Console.WriteLine(convertedDate3);
            Console.WriteLine(convertedDate4);
            Console.WriteLine(convertedDate5);

            DateTime currentDay = DateTime.Today;
            Console.WriteLine(currentDay);

            DateTime currentDateTime = DateTime.Now;
            Console.WriteLine(currentDateTime);

            DateTime currentDate = DateTime.Today.Date;

            DateTime addedDays = currentDate.AddDays(5);
            DateTime removedDays = currentDateTime.AddDays(-5);
            DateTime addMonth = currentDateTime.AddMonths(2);
            DateTime addYear = currentDateTime.AddYears(4);
            DateTime addHours = currentDateTime.AddHours(3);

            int yera = currentDateTime.Year;
            int dat = currentDateTime.Day;
            int month = currentDateTime.Month;

            string dateFormat1 = currentDateTime.ToString("mm/dd/yyyy");
            string dateFormat2 = currentDateTime.ToString("dddd, dd MMMM yyyy");
            string dateFormat3 = string.Format("Today is {0:MM/dd/yyyy}, {0:dddd}", currentDateTime);
            string dateFormat4 = string.Format("Today is {0:dd-MMMM-yyyy}, {0:t}", currentDateTime);
            string dateFormat5 = currentDateTime.ToShortDateString();

            Console.WriteLine(dateFormat1);
            Console.WriteLine(dateFormat2);
            Console.WriteLine(dateFormat3);
            Console.WriteLine(dateFormat4);
            Console.WriteLine(dateFormat5);

            Console.ReadLine();
        }
    }
}
