using SEDC.Oop.Class07.Exercise.Models;
using System;
using SEDC.Oop.Class07.Exercise.Models.Enums;

namespace SEDC.Oop.Class07.Exercise.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Aneta", "Stankovska", 1000);
            Console.WriteLine(employee);

            SalesPerson salesPerson = new SalesPerson("Bob", "Bobsky");
            Console.WriteLine(salesPerson);

            Console.ReadLine();
        }
    }
}
