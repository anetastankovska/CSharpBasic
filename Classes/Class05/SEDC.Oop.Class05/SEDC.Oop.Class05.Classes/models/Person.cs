using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Oop.Class05.Classes.models
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        private long SSN { get; set; }

        private long GenerateSSN()
        {
            Random rand = new Random();
            long ssn = rand.Next(100_000, 999_999);
            return ssn;
        }

        public void Talk(string text)
        {
            Console.WriteLine($"The human named {Name}(SSN: {SSN}) is saying {text}");
        }
    }
}
