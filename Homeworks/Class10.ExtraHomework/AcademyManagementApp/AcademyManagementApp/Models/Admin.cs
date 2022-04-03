using AcademyManagementApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AcademyManagementApp.Models
{
    public class Admin : Person
    {
        public AcademyService Service { get; set; }

        public Admin() { }

        public Admin(string username, string password, string firstName, string lastName)
            : base(username, password, firstName, lastName)
        {

        }
        public void AddPerson()
        {
            Console.Clear();
            Person person = new Person();
            string data = "Please enter the role you wish to add";
            data += "\n1. Admin \n2. Trainer \n3. Student";
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
            Console.WriteLine("Enter the username:");
            while (true)
            {
                try
                {
                    string tempUsername = Console.ReadLine();
                    if (Service.People.Exists(x => x.Username == tempUsername))
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

            Console.WriteLine("Enter the password:");
            while (true)
            {
                try
                {
                    string tempPassword = Console.ReadLine();
                    if (tempPassword.Length < 7)
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

            Console.WriteLine("Enter the First Name:");
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


            Console.WriteLine("Enter the Last Name:");
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

            Service.AddPerson(person);
            Console.WriteLine($"Person {person.FirstName} {person.LastName} successfully added as {Service.TypeOfPerson(person)}");
            Console.WriteLine("\nList of current People:");
            Service.People.ForEach(x => Console.WriteLine($"{x.FirstName} {x.LastName} ({Service.TypeOfPerson(x)})"));
        }

        public Person RemovePerson()
        {
            Console.Clear();
            List<Person> tempList;
            string data = "Please enter the role you wish to remove";
            data += "\n1. Admins \n2. Trainers \n3. Students";
            int selectedTypeofPerson = Service.ShowMenu(data, 1, 3);

            switch (selectedTypeofPerson)
            {
                case 1:
                    Service.ShowAdmins();
                    tempList = Service.GetAdmins().Select(x => x as Person).ToList();
                    break;
                case 2:
                    Service.ShowTrainers();
                    tempList = Service.GetTrainers().Select(x => x as Person).ToList();
                    break;
                case 3:
                    Service.ShowStudents();
                    tempList = Service.GetStudents().Select(x => x as Person).ToList();
                    break;
                default:
                    tempList = default;
                    break;
            }
            int chosenIndex = Service.ShowMenu("Please select the user you want to remove", 1, tempList.Count);
            Person personForRemoval = tempList[chosenIndex - 1];

            if (personForRemoval.Username == this.Username)
            {
                throw new Exception("You cannot remove yourself.");
            }

            Service.RemovePerson(personForRemoval);
            Console.Clear();
            Console.WriteLine($"Person {personForRemoval.FirstName} {personForRemoval.LastName} as {Service.TypeOfPerson(personForRemoval)} successfully removed ");
            Console.WriteLine("\nList of current People:");
            Service.People.ForEach(x => Console.WriteLine($"{x.FirstName} {x.LastName} ({Service.TypeOfPerson(x)})"));
            return personForRemoval;
        }
    }
}
