using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Oop.Class05.Exercises.Students.models
{
    class Student
    {
        public string Name { get; set; }
        public string Academy { get; set; }
        public string Group { get; set; }

        public Student(string name, string academy, string group)
        {
            Name = name;
            Academy = academy;
            Group = group;
        }

        public string GetUserInformation()
        {
            string str = $"The name of the student is {Name}, they are studying {Academy} academy in group {Group}";
            return str;
        }
    }
}
