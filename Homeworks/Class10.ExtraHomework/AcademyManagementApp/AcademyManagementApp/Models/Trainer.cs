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
        public Student ReadStudents()
        {
            List<Student> students = Service.GetStudents();
            Service.ShowStudents();
            int chosenIndex = Service.ShowMenu("Choose a student to see details", 1, students.Count);
            Student chosenStudent = students[chosenIndex];
            Console.WriteLine(chosenStudent);
            return chosenStudent;
        }

        public void ReadStudentSubject(Student student)
        {
            foreach (string key in student.Grades.Keys)
            {
                Console.WriteLine($"{key} : {student.Grades[key]}");
            }
        }

        public void ReadSubjects()
        {
            Service.ShowSubjects();
        }
    }
}
