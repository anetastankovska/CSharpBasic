using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEDC.Oop.Class07.Models;
using SEDC.Oop.Class07.Models.Enums;

namespace SEDC.Oop.Class07.Services
{
    public class EmployeeService
    {
        public void CreateObjectAndWriteInConsole()
        {
            Employee employee = new Employee() { Id = 1, Name = "Bob", Role = Role.Admin};
            Console.WriteLine($"Employee {employee.Name} is created");
        }
    }
}
