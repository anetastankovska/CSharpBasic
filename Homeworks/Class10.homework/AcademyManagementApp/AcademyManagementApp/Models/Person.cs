using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyManagementApp.Models
{
    public class Person
    {
        public string Username { get; private set; }
        public string Password { get; private set; }
        public string FirstName { get; }
        public string LastName { get; }

        public Person(string username, string password, string firstName, string lastName)
        {
            Username = username;
            Password = password;
            FirstName = firstName;
            LastName = lastName;
        }
    }


}
