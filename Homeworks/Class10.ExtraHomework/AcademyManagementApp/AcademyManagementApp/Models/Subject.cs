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
        public List<Student> Students { get; set; }

        public Subject()
        {
            Students = new List<Student>();
        }
    }
}
