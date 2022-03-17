using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Oop.Class05.Exercises.Models
{
    public class Human
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public Human(string fName, string lName, int age)
        {
            FirstName = fName;
            LastName = lName;
            Age = age;
        }

        public HumanInfoResult GetHumanInfo()
        {
            HumanInfoResult hir = new HumanInfoResult
            {
                Age = Age,
                FullName = string.Format("{0} {1}", FirstName, LastName),
            };
            return hir;
        }
    }
}
