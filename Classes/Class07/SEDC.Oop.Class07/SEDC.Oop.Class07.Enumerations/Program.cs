using SEDC.Oop.Class07.Enumerations.Models;
using SEDC.Oop.Class07.Enumerations.Enums;
using System;

namespace SEDC.Oop.Class07.Enumerations
{
    class Program
    {
        static void Main(string[] args)
        {
            Administrator admin = new Administrator("Bob");
            admin.Role = Roles.SuperGuest;
            string a = Console.ReadLine();

            bool isValed = Enum.TryParse(a, out Roles role);
            

            Console.ReadLine();
        }
    }
}
