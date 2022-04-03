using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyManagementApp.Models
{
    public class Subject
    {
        public string Title { get; set; }
        List<Student> StudentsAttended { get; set; }

        public Subject(string title, List<Student> studentsAttended)
        {
            Title = title;
            StudentsAttended = new List<Student>();
        }

        public Subject(string title)
        {
            Title = title;
        }

        public override string ToString()
        {
            return Title;
        }
    }
}
