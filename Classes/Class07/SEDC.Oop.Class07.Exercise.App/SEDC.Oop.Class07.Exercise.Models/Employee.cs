using SEDC.Oop.Class07.Exercise.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Oop.Class07.Exercise.Models
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        protected double Salary { get; set; }
        public Role Role { get; set; }

        public Employee()
        {

        }

        public Employee(string firstName, string lastName, double salary, Role role )
        {
            FirstName = firstName;
            LastName = lastName;
            Salary = salary;
            Role = role;

        }
        public void PrintInfo()
        {
            Console.WriteLine($"First name: {FirstName} last name: {LastName}, salary: {Salary}");
        }

        virtual public double GetSalary()
        {
            Console.WriteLine($"The salary of {FirstName} is {Salary}");
            return Salary;
        }
    }
}
