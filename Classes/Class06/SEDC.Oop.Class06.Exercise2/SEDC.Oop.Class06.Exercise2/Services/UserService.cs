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
        User[] users;

        public UserService()
        {
            users = new User[]
            {
                new User(01, "Aneta", "Password01", new string[] { "Hello Aneta", "Nice to see you again" }),
                new User(02, "Aleksandar", "Password02", new string[2] { "Hi Aleksandar", "Welcome back" }),
                new User(03, "Stefan", "Password03", new string[2] { "Hello Stefan", "Glad to see you back" })
            };
        }
        public User Login()
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
                    Console.WriteLine("\nIf you want to edit your data, press Y");
                    string response = Console.ReadLine();
                    if(response == "Y")
                    {
                        EditUser(users[i]);
                    }
                    return users[i];
                }
            }
            Console.WriteLine("Error!");
            return null;
        }

        private void EditUser(User user)
        {
            Console.WriteLine("For editing username, press U, for editing password press P.");
            string choice = Console.ReadLine();
            if(choice == "U")
            {
                Console.WriteLine("Enter your new username");
                string newUsername = Console.ReadLine();
                user.Username = newUsername;
                Console.WriteLine($"Your new username is {user.Username}");
            }
            else if(choice == "P")
            {
                Console.WriteLine("Enter your new password");
                string newPassword = Console.ReadLine();
                user.Username = newPassword;
                Console.WriteLine($"Your new password is {user.Password}");
            }
            else
            {
                Console.WriteLine("Wrong input");
                return;
            }
        }

        private void PrintMessages(User user)
        {
            string joinedMsgs = string.Join(",", user.Messages);
            Console.WriteLine(joinedMsgs);
        }

        public User[] Register()
        {
            Console.WriteLine("Enter your username:");
            string username = Console.ReadLine();

            while (CheckIfUserExists(username))
            {
                Console.WriteLine("The username already exists. Try another one.");
                username = Console.ReadLine();
            }

            Console.WriteLine("Enter your ID:");
            string userId = Console.ReadLine();
            bool isValidInt = int.TryParse(userId, out int id);
            Console.WriteLine("Enter your password:");
            string password = Console.ReadLine();

            AddNewUser(new User(id, username, password));
            Console.WriteLine("Registration complete! \nUsers:");
            PrintUsers();
            return users;
        }

        private bool CheckIfUserExists(string username)
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

        private void AddNewUser(User user)
        {
            Array.Resize(ref users, users.Length + 1);
            users[users.Length -1] = user;
        }

        private void PrintUsers()
        {
            for (int i = 0; i < users.Length; i++)
            {
                Console.WriteLine(users[i].Username);
            }
        }




    }
}
