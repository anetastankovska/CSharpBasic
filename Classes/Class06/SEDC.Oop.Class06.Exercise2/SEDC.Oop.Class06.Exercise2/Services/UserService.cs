using SEDC.Oop.Class06.Exercise2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Oop.Class06.Exercise2.Services
{
    public class UserService
    {
        public User Login(User[] users)
        {
            Console.WriteLine("Enter your username:");
            string username = Console.ReadLine();
            Console.WriteLine("Enter your password:");
            string password = Console.ReadLine();

            for (int i = 0; i < users.Length; i++)
            {
                if (username == users[i].Username && password == users[i].Password)
                {
                    Console.WriteLine($"Welcome {users[i].Username.ToUpper()}. Here are your messages: \n");
                    PrintMessages(users[i]);
                    return users[i];
                }
            }
            Console.WriteLine("Error!");
            return null;
        }

        private void PrintMessages(User user)
        {
            string joinedMsgs = string.Join(",", user.Messages);
            Console.WriteLine(joinedMsgs);
        }

        public User[] Register(User[] users)
        {
            Console.WriteLine("Enter your username:");
            string username = Console.ReadLine();

            while (CheckIfUserExists(users, username))
            {
                Console.WriteLine("The username already exists. Try another one.");
                username = Console.ReadLine();
            }

            Console.WriteLine("Enter your ID:");
            string userId = Console.ReadLine();
            bool isValidInt = int.TryParse(userId, out int id);
            Console.WriteLine("Enter your password:");
            string password = Console.ReadLine();

            AddNewUser(new User(id, username, password), ref users);
            Console.WriteLine("Registration complete! \nUsers:");
            PrintUsers(users);
            return users;
        }

        private bool CheckIfUserExists(User[] users, string username)
        {
            for (int i = 0; i < users.Length; i++)
            {
                if (username == users[i].Username)
                {
                    Console.WriteLine("There is already user called like that.");
                    return true;
                }
            }
            return false;
        }

        private void AddNewUser(User user, ref User[] users)
        {
            Array.Resize(ref users, users.Length + 1);
            users[users.Length -1] = user;
        }

        private void PrintUsers(User[] users)
        {
            for (int i = 0; i < users.Length; i++)
            {
                Console.WriteLine(users[i].Username);
            }
        }




    }
}
