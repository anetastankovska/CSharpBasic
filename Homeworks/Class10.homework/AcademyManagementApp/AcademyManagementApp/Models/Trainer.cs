using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyManagementApp.Models
{
    public class Trainer : Person
    {
        public List<Student> Students { get; set; }
        public List<Subject> Subjects { get; set; }
        public Trainer(string username, string password, string firstName, string lastName)
            : base(username, password, firstName, lastName)
        {
            Students = new List<Student>();
            Subjects = new List<Subject>();
        }
        public void AddGrade(Student student, Subject subject, int grade)
        {
            student.Grades[subject] = grade;
        }
    }
}
