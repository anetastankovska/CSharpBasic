using AcademyManagementApp.Models;
using AcademyManagementApp.App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyManagementApp.Services
{
    public static class Helpers
    {
        public static int HandleMenuInput(string input, int min, int max)
        {
            bool isValidInput = int.TryParse(input, out int validInput);
            if(isValidInput && validInput > min && validInput <= max)
            {
                return validInput;
            }
            throw new Exception("The selected option is not valid");
        }


        public static bool validateAdminLogin(string username, string password, List<Admin> admins)
        {
            foreach (Admin admin in admins)
            {
                if(username == admin.Username && password == admin.Password)
                {
                    return true;
                }
                throw new Exception("The provided credentials are not valid");
            }
            return false;
        }

        public static bool validateTranerLogin(string username, string password, List<Trainer> trainers)
        {
            foreach (Trainer trainer in trainers)
            {
                if (username == trainer.Username && password == trainer.Password)
                {
                    return true;
                }
                throw new Exception("The provided credentials are not valid");
            }
            return false;
        }

        public static bool validateStudentLogin(string username, string password, List<Student> students)
        {
            foreach (Student student in students)
            {
                if (username == student.Username && password == student.Password)
                {
                    return true;
                }
                throw new Exception("The provided credentials are not valid");
            }
            return false;
        }
    }
}
