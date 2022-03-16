using System;

//Task
//Make a method called AgeCalculator
//The method will have one input parameter, your birthday date
//The method should return your age
//Show the age of a user after he inputs a date
//Note: take into consideration if the birthday is today, after or before today

namespace Class04.homework
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter your date of birth in the following formats: dd/mm/yyyy OR yyyy/mm/dd OR dd.mm.yyyy OR yyyy.mm.dd");
            string userBirthDate = Console.ReadLine();
            bool isValidDate = DateTime.TryParse(userBirthDate, out DateTime parsedDate);

            //Using while loop and asking the user until getting a date in right format
            while (!isValidDate)
            {
                Console.WriteLine(@"Please enter your birth date in a valid format! If you want to exit press ""X""");
                userBirthDate = Console.ReadLine();
                if(userBirthDate.ToUpper() == "X")
                {
                    return;
                }
                isValidDate = DateTime.TryParse(userBirthDate, out parsedDate);
            }

            // Using if statement and letting the user enter a date only once
            //if (!isValidDate)
            //{
            //    Console.WriteLine("Your input is not in valid format!");
            //    return;
            //}

            AgeCalculator(parsedDate);
            //AgeCalculator2(parsedDate);

            Console.ReadLine();
        }

        public static int AgeCalculator(DateTime birthDate)
        {
            int age = 0;

            DateTime today = DateTime.Now;
            int currentYear = today.Year;
            int currentMonth = today.Month;
            int currentDay = today.Day;

            int birthYear = birthDate.Year;
            int birthMonth = birthDate.Month;
            int birthDay = birthDate.Day;

            age = currentYear - birthYear;

            if (currentMonth < birthMonth)
            {
                Console.WriteLine($"Your age is {age -1}");
            }
            else if (currentMonth > birthMonth)
            {
                Console.WriteLine($"Your age is {age}");
            }
            else if (currentMonth == birthMonth && currentDay == birthDay)
            {
                Console.WriteLine($"Today is your birthday. You turn {age} today");
            }
            return age;
        }


        //If we want to check only for age, without checking the birthday we can subtract dates without parsing them and by using TimeSpan data type
        public static int AgeCalculator2(DateTime birthDate)
        {
            DateTime today = DateTime.Today;

            TimeSpan age = today - birthDate;
            Console.WriteLine($"Your current age is { Math.Floor(age.Days / 365.2425)}");

            return 0;
        }


    }
}
