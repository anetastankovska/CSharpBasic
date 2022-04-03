using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyManagementApp.Models
{
    public class Student : Person
    {
        public Subject CurrentSubject { get; set; }
        public Dictionary<string, int> Grades { get; set; }

        public Student()
        {
            Grades = new Dictionary<string, int>();
        }
        public Student(string username, string password, string firstName, string lastName)
            : base(username, password, firstName, lastName)
        {
            Grades = new Dictionary<string, int>();
        }

        public override string ToString()
        {
            List<string> data = new List<string>();
            data.Add($"The subject you are currently attending is {CurrentSubject}");
            data.Add("Your grades per subject:");
            foreach (string key in Grades.Keys)
            {
                data.Add($"{key}: {Grades[key]}");
            }
            string result = string.Join("\n", data);
            return result;
        }

    }
}
