using AcademyManagementApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AcademyManagementApp.Services
{
    public class AcademyService
    {
        public List<Person> People { get; set; }
        public List<Subject> Subjects { get; set; }

        public AcademyService() 
        {
            People = new List<Person>();
            Subjects = new List<Subject>();
        }

        public void InitializeData()
        {
            List<Subject> subjects = new List<Subject>
            {
                new ("HTMLAndCSS"),
                new ("JavaScriptBasic"),
                new ("JavaScriptAdvanced"),
                new ("CSharpBasic"),
                new ("CSharpAdvanced")
            };
            subjects.ForEach(x => Subjects.Add(x));

            List<Admin> admins = new List<Admin>
            {
                new ("admin1", "admin123", "Aneta", "Stankovska"),
                new ("admin2", "admin234", "Stefan", "Ivanovski"),
                new ("admin3", "admin345", "Aleksandar", "Zivkovic")
            };

            List<Trainer> trainers = new List<Trainer>
            {
                new ("trainer1", "trainer123", "Trajan", "Stevkovski"),
                new ("trainer2", "trainer234", "Vlatko", "Tasevski"),
                new ("trainer3", "trainer345", "Nikola", "Dalchevski")
            };

            List<Student> students = new List<Student>
            {
                new ("student1", "student123", "Igor", "Nikoloski"){ Grades = GenerateGrades(3)},
                new ("student2", "student234", "Marija", "Kolevska"){ Grades = GenerateGrades(5)},
                new ("student3", "student345", "Ilija", "Mitev") { Grades = GenerateGrades(2)},
                new ("student4", "student456", "Maja", "Nikolic") { Grades = GenerateGrades(4)},
                new ("student5", "student567", "Kristijan", "Karanfilovski") { Grades = GenerateGrades(3)},
                new ("student6", "student678", "Ana", "Kirovska") { Grades = GenerateGrades(5)},
                new ("student7", "student789", "Slave", "Trajkovski") { Grades = GenerateGrades(5)},
                new ("student8", "student891", "Timotej", "Bojarovski") { Grades = GenerateGrades(4)},
                new ("student9", "student912", "Bob", "Bobsky"){ Grades = GenerateGrades(2)},
            };


            enrollToSubject(students[0], subjects[0]);
            enrollToSubject(students[1], subjects[1]);
            enrollToSubject(students[3], subjects[3]);
            enrollToSubject(students[4], subjects[4]);
            enrollToSubject(students[5], subjects[3]);
            enrollToSubject(students[6], subjects[4]);
            enrollToSubject(students[7], subjects[3]);
            enrollToSubject(students[8], subjects[1]);

            admins.ForEach(x => People.Add(x));
            trainers.ForEach(x => People.Add(x));
            students.ForEach(x => People.Add(x));
            
        }

        public List<Student> GetStudents()
        {
            List<Student> students = People.Where(x => x.GetType() == typeof(Student)).Select(x => (Student)x).ToList();
            return students;
        }

        public List<Admin> GetAdmins()
        {
            List<Admin> admins = People.Where(x => x.GetType() == typeof(Admin)).Select(x => (Admin)x).ToList();
            return admins;
        }

        public List<Trainer> GetTrainers()
        {
            List<Trainer> trainers = People.Where(x => x.GetType() == typeof(Trainer)).Select(x => (Trainer)x).ToList();
            return trainers;
        }

        public void ShowStudents()
        {
            List<Student> students = GetStudents();
            Console.WriteLine("Students:");
            int counter = 1;
            foreach (Student student in students)
            {
                Console.WriteLine($"{counter++}. {student.FirstName} {student.LastName}");
            }
        }

        public void ShowAdmins()
        {
            List<Admin> admins = GetAdmins();
            Console.WriteLine("Admins");
            int counter = 1;
            foreach(Admin admin in admins)
            {
                Console.WriteLine($"{counter++}. {admin.FirstName} {admin.LastName}");
            }
        }

        public void ShowTrainers()
        {
            List<Trainer> trainers = GetTrainers();
            Console.WriteLine("Trainers");
            int counter = 1;
            foreach(Trainer trainer in trainers)
            {
                Console.WriteLine($"{counter++}. {trainer.FirstName} {trainer.LastName}");
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

        public Person Login()
        {
            try
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
                if (selected.GetType() == typeof(Trainer))
                {
                    (selected as Trainer).Service = this;
                    return selected as Trainer;
                }
                else if (selected.GetType() == typeof(Admin))
                {
                    (selected as Admin).Service = this;
                    return selected as Admin;
                }
                return selected as Student;
            }
            catch (ArgumentNullException)
            {
                Console.Write("User not found. Please wait");
                for (int i = 0; i < 3; i++)
                {
                    Console.Write(".");
                    Thread.Sleep(1000);
                }
                return null;
            }

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

        public string TypeOfPerson(Person person)
        {
            return person.GetType().ToString().Split(".").Last();
        }

        public void enrollToSubject(Student student, Subject subject)
        {
            student.CurrentSubject = subject;
            subject.Students.Add(student);
        }

        public Dictionary<string, int> GenerateGrades(int numberOfSubjects)
        {
            List<string> predmeti = Subjects.Select(x => x.Title).ToList();
            Random rnd = new Random();
            Dictionary<string, int> result = new Dictionary<string, int>();
            while (result.Count < numberOfSubjects)
            {
                string temp = predmeti[rnd.Next(predmeti.Count - 1)];
                result.Add(temp, rnd.Next(4)+1);
                predmeti.Remove(temp);
            }
            return result;
        }
    }
}
