using SEDC.Oop.Class07.Exercise.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Oop.Class07.Exercise.Models
{
    public class CEO : Employee
    {
        public Employee[] Employees { get; set; }
        public int Shares { get; set; }
        private double SharesPrice;

        public CEO(string firstName, string lastName, int salary, Role role, Employee[] employees, int shares)
            :base(firstName, lastName, salary, role)
        {
            Employees = employees;
            Shares = shares;
        }

        public double AddSharePrice(int number)
        {
            SharesPrice = number;
            return SharesPrice;
        }

        public void PrintEmployees()
        {
            Console.WriteLine("Employees: ");
            for(int i = 0; i < Employees.Length; i++)
            {
                Console.WriteLine($"{Employees[i].FirstName} {Employees[i].LastName} - {Employees[i].Role}");
            }
        }

        public override double GetSalary()
        {
            Salary = Salary + Shares * SharesPrice;
            Console.WriteLine($"The salary of ceo is {Salary}");
            return Salary;
        }
    }
}
