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
        public Role Role { get; set; }

        public SalesPerson()
        {
            Salary = 500;
            Role = Role.Sales;  
        }

        public SalesPerson(string firstName, string lastName, double salary, Role role)
            : base(firstName, lastName, salary)
        {
            Role = Role.Sales;
        }

        public void AddSuccessSaleRevenue(int revenue)
        {
            SuccessSaleRevenue = revenue;
        }


        public override double GetSalary()
        {
            if(SuccessSaleRevenue <= 2000)
            {
                Salary += 500;
            }
            else if(SuccessSaleRevenue >= 2000 && SuccessSaleRevenue <= 5000)
            {
                Salary += 1000;
            }
            else if(SuccessSaleRevenue > 5000)
            {
                Salary += 1500;
            }
            return Salary;
        }


    }
}
