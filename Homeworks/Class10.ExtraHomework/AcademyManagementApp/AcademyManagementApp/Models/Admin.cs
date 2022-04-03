using AcademyManagementApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyManagementApp.Models
{
    public class Admin : Person
    {
        public AcademyService Service { get; set; }
        public void AddPerson()
        {
            Person person = new Person();
            string data = "Please enter your role";
            data += "\n1. Admin \n2.Trainer \n3. Student";
            int selectedPerson = Service.ShowMenu(data, 1, 3);
            switch (selectedPerson)
            {
                case 1:
                    person = new Admin();
                    break;
                case 2:
                    person = new Trainer();
                    break;
                case 3:
                    person = new Student();
                    break;
                default:
                    break;
            }
            Console.WriteLine("Enter your username:");
            while (true)
            {
                try
                {
                    string tempUsername = Console.ReadLine();
                    if(Service.People.Exists(x => x.Username == tempUsername))
                    {
                        throw new Exception("The user already exists");
                    }
                    person.Username = tempUsername;
                    break;
                    
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            Console.WriteLine("Enter your password:");
            while (true)
            {
                try
                {
                    string tempPassword = Console.ReadLine();
                    if (tempPassword.Length < 8)
                    {
                        throw new Exception("The password is too shot. Please try another one");
                    }
                    person.Password = tempPassword;
                    break;

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            Console.WriteLine("Enter your First Name:");
            while (true)
            {
                try
                {
                    string tempFirstName = Console.ReadLine();
                    if (string.IsNullOrEmpty(tempFirstName))
                    {
                        throw new Exception("The first name is too short. Please try another one");
                    }
                    person.FirstName = tempFirstName;
                    break;

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            Console.WriteLine("Enter your Last Name:");
            while (true)
            {
                try
                {
                    string tempLastName = Console.ReadLine();
                    if (string.IsNullOrEmpty(tempLastName))
                    {
                        throw new Exception("The first name is too short. Please try another one");
                    }
                    person.LastName = tempLastName;
                    break;

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            Service.People.Add(person);
        }



        public void RemovePerson(Person person)
        {
            Service.RemovePerson(person);
        }
    }
}
