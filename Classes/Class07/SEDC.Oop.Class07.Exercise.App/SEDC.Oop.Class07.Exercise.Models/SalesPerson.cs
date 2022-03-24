using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEDC.Oop.Class07.Exercise.Models.Enums;


namespace SEDC.Oop.Class07.Exercise.Models
{
    public class SalesPerson : Employee
    {
        private double SuccessSaleRevenue { get; set; }

        public SalesPerson(string firstName, string lastName, double salary = 500)
            : base(firstName, lastName, salary, Role.Sales)
        {
        }

        public void AddSuccessSaleRevenue(int revenue)
        {
            SuccessSaleRevenue = revenue;
        }

        public override double GetSalary()
        {
            //I did this because if we call get salary 3 times it will increase it on each call
            double temp = Salary;
            if(SuccessSaleRevenue <= 2000)
            {
                temp += 500;
            }
            else if(SuccessSaleRevenue >= 2000 && SuccessSaleRevenue <= 5000)
            {
                temp += 1000;
            }
            else if(SuccessSaleRevenue > 5000)
            {
                temp += 1500;
            }
            Console.WriteLine($"The salary of {FirstName} is {Salary}");
            return temp;
        }


    }
}
