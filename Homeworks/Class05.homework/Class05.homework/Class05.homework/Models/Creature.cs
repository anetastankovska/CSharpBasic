using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class05.homework.Models
{
    class Creature
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int PowerLevel { get; set; }
        public bool IsTamed { get; set; }

        public Creature (string name, int age, int powerLevel, bool isTamed)
        {
            Name = name;
            Age = age;
            PowerLevel = powerLevel;
            IsTamed = isTamed;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Power Level: {PowerLevel}";
        }

        public static Creature CreatureWithMaxPowerLevel(Creature[] creatures)
        {
            Creature max = creatures[0];
            for (int i = 0; i < creatures.Length; i++)
            {
                if (creatures[i].PowerLevel > max.PowerLevel)
                {
                    max = creatures[i];
                }
            }
            return max;
        }
    }
}
