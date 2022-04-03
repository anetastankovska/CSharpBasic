using AcademyManagementApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyManagementApp.Services
{
    public class AcademyService
    {
        public List<Person> People { get; set; }
        public List<Subject> Subjects { get; set; }

        public List<Student> GetStudents()
        {
            List<Student> students = People.Where(x => x.GetType() == typeof(Student)).Select(x => (Student)x).ToList();
            return students;
        }
        public Person Login()
        {
            Console.WriteLine("Enter your username");
            string username = Console.ReadLine();
            Person selected = People.FirstOrDefault(x => x.Username == username);
            if (selected == default)
            {
                Console.WriteLine("The user has not been found.");
                return null;
            }
            Console.WriteLine("Enter your password");
            string password = Console.ReadLine();
            if (selected.Password != password)
            {
                Console.WriteLine("The password is incorrect.");
                return null;
            }
            if(selected.GetType() == typeof(Trainer))
            {
                (selected as Trainer).Service = this;
                return selected as Trainer;
            }
            else if(selected.GetType() == typeof(Admin))
            {
                (selected as Admin).Service = this;
                return selected as Admin;
            }
            return selected as Student;
        }

        public void ShowStudents()
        {
            List<Student> students = GetStudents();
            int counter = 1;
            Console.WriteLine("Students:");
            foreach (Student student in students)
            {
                Console.WriteLine($"{counter++}. {student.FirstName} {student.LastName}");
            }
        }

        public void ShowSubjects()
        {
            foreach (Subject subject in Subjects)
            {
                Console.WriteLine($"{subject.Title}: {subject.Students.Count}");
            }
        }

        public int ShowMenu(string message, int min, int max)
        {
            Console.WriteLine(message);

            int chosen = HandleInput(min, max);
            return chosen;
        }

        public int HandleInput(int min, int max)
        {
            int result = int.MinValue;
            string input = Console.ReadLine();
            while (int.TryParse(input, out result) && result < min && result > max)
            {
                Console.WriteLine("Please enter a valid input.");
                input = Console.ReadLine();
            }
            return result;
        }

        public void AddPerson(Person person)
        {
            People.Add(person);
        }

        public void RemovePerson(Person person)
        {
            People.Remove(person);
        }
    }
}
