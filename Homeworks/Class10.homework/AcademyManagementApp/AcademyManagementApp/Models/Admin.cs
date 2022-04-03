using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyManagementApp.Models
{
    public class Admin : Person
    {
        public Admin(string username, string password, string firstName, string lastName)
            : base(username, firstName, lastName, password)
        {

        }

        public void EnrollStudent(Student student, Subject subject)
        {
            student.Subjects.Add(subject);
        }

    }
}
