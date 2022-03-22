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
        public User[] Login(string username, string password, User[] users)
        {
            for (int i = 0; i < users.Length; i++)
            {
                if (username == users[i].Username && password == users[i].Password)
                {
                    Console.WriteLine($"Welcome {users[i].Username.ToUpper()}. Here are your messages: \n");
                    PrintMessages(users[i]);
                }
                else
                {
                    Console.WriteLine("Error!");
                    break;
                }
            }
            return users;
        }

        private void PrintMessages(User user)
        {
            for(int i = 0; i < user.Messages.Length; i++)
            {
                Console.WriteLine(user.Messages);
            }
        }

        public User[] Register(User[] users, int id, string username, string password)
        {
            for (int i = 0; i < users.Length; i++)
            {
                if (username == users[i].Username)
                {
                    Console.WriteLine("There is already user called like that");
                    break;
                }
                AddNewUser(new User(id, username, password), users);
                Console.WriteLine("Registration complete! \nUsers:");
                PrintUsers(users);
            }
            return users;
        }

        private User[] AddNewUser(User user, User[] users)
        {
            Array.Resize(ref users, users.Length + 1);
            users[users.Length] = user;
            return users;
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
