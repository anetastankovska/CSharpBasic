using SEDC.Oop.Class07.Exercise.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Oop.Class07.Exercise.Models
{
    public class Manager : Employee
    {
        private double Bonus;
        
        //I added a department property to the Manager so that I can assign them as Manager to the Contractor
        public Department Department { get; set; }

        public Manager(string firstName, string lastName, double salary, Department department)
            :base(firstName, lastName, salary, Role.Manager)
        {
            Department = department;
            Bonus = 0;
        }

        public void AddBonus(int number)
        {
            Bonus += number;
        }

        public override double GetSalary()
        {
            Console.WriteLine($"The salary of {FirstName} is {Salary}");
            return Salary + Bonus;   
        }
    }

  
}
