using AcademyManagementApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyManagementApp.Models
{
    public class Trainer : Person
    {
        public AcademyService Service { get; set; }

        public Trainer() { }
        public Trainer(string username, string password, string firstName, string lastName)
            :base(username, password, firstName, lastName)
        {

        }
        public void ReadStudents()
        {
            List<Student> students = Service.GetStudents();
            Service.ShowStudents();
            int chosenIndex = Service.ShowMenu("Choose a student to see details", 1, students.Count);
            Student chosenStudent = students[chosenIndex];
            Console.WriteLine(chosenStudent);
        }

        public void ReadSubjects()
        {
            Service.ShowSubjects();
        }
    }
}
