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
            Console.WriteLine(employee.FirstName);

            SalesPerson salesPerson = new SalesPerson("Bob", "Bobsky");
            Console.WriteLine(salesPerson.FirstName);

            Manager manager = new Manager("Aleksandar", "Zivkovic", 1000, Department.Finance);
            Console.WriteLine(manager.FirstName);

            Contractor contractor = new Contractor("Stefan", "vanovski", 1200, 40, 10, manager);
            Console.WriteLine(contractor.FirstName);

            Console.ReadLine();
        }
    }
}
