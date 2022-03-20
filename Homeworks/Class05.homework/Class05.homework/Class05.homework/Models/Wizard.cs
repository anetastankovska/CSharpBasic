using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class05.homework.Models
{
    class Wizard
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int PowerLevel { get; set; }
        public DateTime DateOfAdmission { get; set; }
        public bool IsGraduated { get; set; }

        public Wizard(string name, int age, int powerLevel, DateTime dateOfAdmission, bool isGraduated)
        {
            Name = name;
            Age = age;
            PowerLevel = powerLevel;
            DateOfAdmission = dateOfAdmission;
            IsGraduated = isGraduated;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Power Level: {PowerLevel}";
        }

        public static Wizard WizardWithMaxPowerLevel(Wizard[] wizards)
        {
            Wizard max = wizards[0];
            for (int i = 0; i < wizards.Length; i++)
            {
                if (wizards[i].PowerLevel > max.PowerLevel)
                {
                    max = wizards[i];
                }
            }
            return max;
        }
    }
}
