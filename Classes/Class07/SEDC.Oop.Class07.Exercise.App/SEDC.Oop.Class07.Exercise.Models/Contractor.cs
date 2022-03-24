using SEDC.Oop.Class07.Exercise.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Oop.Class07.Exercise.Models
{
    public class Contractor : Employee
    {
        public double WorkHours { get; set; }
        public int PayPerHour { get; set; }
        public Manager Responsible { get; set; }

        public Contractor()
        {

        }

        public Contractor(string firstName, string lastName, double salary, double workHours, int payPerHour, Manager responsible)
            : base(firstName, lastName, salary, Role.Other)
        {
            WorkHours = workHours;
            PayPerHour = payPerHour;
            Responsible = responsible;
        }

        public override double GetSalary()
        {
            Console.WriteLine($"The salary of {FirstName} is {Salary}");
            return WorkHours * PayPerHour;
        }

        public Department CurrentPosition()
        {
            return Responsible.Department;
        }
    }
}
