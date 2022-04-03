using AcademyManagementApp.Models;
using AcademyManagementApp.App;
using AcademyManagementApp.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyManagementApp.Services
{
    public static class Menus
    {
        public static int MainMenu()
        {
            Console.WriteLine("Welcome to the Academy Management Application");
            Console.WriteLine("Please select your role");
            Console.WriteLine("1. Admin \n2. Trainer \n3. Student \n\nTo exit press 0");
            int result = 0;
            while (result < 1 && result > 3)
            {
                try
                {
                    string userInput = Console.ReadLine();
                    result = Helpers.HandleMenuInput(userInput, 0, 3);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return result;
        }

        public static void AdminWelcomeScreen()
        {
            Console.WriteLine("Welcome to the admin user app. Please enter your username and password below");
            Console.WriteLine("Username:");
            string username = Console.ReadLine();
            Console.WriteLine("Password");
            string password = Console.ReadLine();
            Helpers.validateAdminLogin(username, password, );
        }

        public static void TrainerWelcomeScreen()
        {
            Console.WriteLine("Welcome to the trainer user app. Please enter your username and password below");
            Console.WriteLine("Username:");
            string username = Console.ReadLine();
            Console.WriteLine("Password");
            string password = Console.ReadLine();
            Helpers.validateAdminLogin(username, password, trainers);
        }

        public static void AdminMenu(Admin admin)
        {
            Console.WriteLine($"Welcome to your menu {admin.FirstName}! \nPlease select an appropriate option below");
            Console.WriteLine("1. Add Admin \n2. Add Trainer \n3. Add Student");
            Console.WriteLine("4. Remove Admin \n5. Remove Trainer \n6. Remove Student");
        }

        public static int TrainerMenu(Trainer trainer)
        {
            Console.WriteLine($"Welcome to your menu {trainer.FirstName}! \nPlease select an appropriate option below");
            Console.WriteLine("1. Students \n2. Subjects");
            int result = 0;
            while (result < 1 && result > 2)
            {
                try
                {
                    string userInput = Console.ReadLine();
                    result = Helpers.HandleMenuInput(userInput, 0, 2);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return result;
        }

        public static void StudenMenu(Student student)
        {
            Console.WriteLine($"Welome to the your menu {student.FirstName}!");
            student.ToString();
        }
    }
}
