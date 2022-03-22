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
            UserService userService = new UserService();

            while (true)
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1. login");
                Console.WriteLine("2. register");
                // validation logic
                int selection = 1;
                switch (selection)
                {
                    case 1:
                        users = userService.Login("", "", users);
                        break;
                    case 2:
                        users = userService.Register(users, 0003, "", "");
                        break;
                    default:
                        //validation error
                        break;
                }
            }
        }
    }
}
