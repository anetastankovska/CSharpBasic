using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Oop.Class07.Exercise.Models
{
    public class Manager : Employee
    {
        private double Bonus { get; set; }

        public Manager(string firstName, string lastName, double salary)
            :base(firstName, lastName, salary)
        {

        }

        public void AddBonus(int number)
        {
            Bonus += number;
        }

        public override double GetSalary()
        {
            return Salary + Bonus;   
        }
    }

  
}
