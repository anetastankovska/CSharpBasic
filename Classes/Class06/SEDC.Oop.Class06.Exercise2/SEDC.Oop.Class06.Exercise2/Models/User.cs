using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Oop.Class06.Exercise2.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string[] Messages { get; set; }

        public User(int id, string username, string password, string[] messages)
        {
            Id = id;
            Username = username;
            Password = password;
            Messages = messages;
        }

        public User(int id, string username, string password)
        {
            Id = id;
            Username = username;
            Password = password;
        }

        public User(string username, string password)
        {
            Username = username;
            Password = password;
        }



    }
}
