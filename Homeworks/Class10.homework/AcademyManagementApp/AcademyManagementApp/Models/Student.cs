using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using AcademyManagementApp.Enums;

namespace AcademyManagementApp.Models
{
    public class Student : Person
    {
        public List<Subject> Subjects { get; set; }
        public Subject CurrentSubject { get; set; }
        public List<int> Grades { get; set; }

        public Student(string username, string password, string firstName, string lastName)
            : base(username, password, firstName, lastName)
        {
            Subjects = new List<Subject>();
            Grades = new List<int>();
        }

        public override string ToString()
        {
            string data = $"The subject you are attending at the moment is {CurrentSubject}";
            data += "\nYour grades:";
            foreach (int i in Grades)
            {
                data += $"\n{i}";
            }
            return data;
        }
    }
}
