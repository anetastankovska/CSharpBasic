using SEDC.Oop.Class07.Exercise.Models;
using System;
using SEDC.Oop.Class07.Exercise.Models.Enums;

namespace SEDC.Oop.Class07.Exercise.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Aneta", "Stankovska", 1000, Role.Other);
            //Console.WriteLine(employee.FirstName);

            SalesPerson salesPerson = new SalesPerson("Bob", "Bobsky");
            //Console.WriteLine(salesPerson.FirstName);

            Manager manager = new Manager("Aleksandar", "Zivkovic", 1000, Department.Finance);
            //Console.WriteLine(manager.FirstName);

            Contractor contractor = new Contractor("Stefan", "Ivanovski", 1200, 40, 10, manager);
            //Console.WriteLine(contractor.FirstName);

            Employee[] employees =
            {
                new Contractor("Johnny", "B", 1500, 40, 12, manager),
                new Contractor("Jill", "M", 2000, 40, 18, manager),
                new Manager("Mary", "S", 2500, Department.InformationTechnology),
                new Manager("Marc", "J", 2300, Department.Operations),
                new SalesPerson("Ashleigh", "F")
            };

            CEO ceo = new CEO("David", "M", 5000, Role.CEO, employees, 150);
            ceo.PrintInfo();
            ceo.AddSharePrice(180);
            ceo.GetSalary();
            ceo.PrintEmployees();
            

            Console.ReadLine();
        }
    }
}
