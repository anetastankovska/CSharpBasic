using SEDC.Oop.Class06.Exercise2.Models;
using SEDC.Oop.Class06.Exercise2.Services;
using System;

namespace SEDC.Oop.Class06.Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            User[] users = new User[3];
            users[0] = new User (01, "Aneta", "Password01", new string[] { "Hello Aneta", "Nice to see you again" });
            users[1] = new User(02, "Aleksandar", "Password02", new string[2] { "Hi Aleksandar", "Welcome back" });
            users[2] = new User(03, "Stefan", "Password03", new string[2] { "Hello Stefan", "Glad to see you back" });


            UserService userService = new UserService();

            string retry = "Y";
            while (retry == "Y")

            {
                Console.Clear();
                Console.WriteLine("Menu");
                Console.WriteLine("To login press 1");
                Console.WriteLine("To register press 2");

                string selection = Console.ReadLine();
                switch (selection)
                {
                    case "1":
                        userService.Login(users);
                        break;
                    case "2":
                        users = userService.Register(users);
                        break;
                    default:
                        Console.WriteLine("You pressed a wrong key! For retry press Y, to exit press X");
                        break;
                }

                retry = Console.ReadLine();
                if(retry == "X")
                {
                    Console.WriteLine("Goodbye");
                    return;
                }
            }
        }
    }
}
