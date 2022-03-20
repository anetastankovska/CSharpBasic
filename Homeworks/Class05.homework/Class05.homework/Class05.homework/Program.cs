using Class05.homework.Models;
using System;

//Requirements
//The head of the board of the Hogwarts school of Witchcraft and Wizardry want to be a bit more ‘hip with the kids’, so they have appointed you as the head of IT and have asked you to model out a new console game, consisting of 2 classes:

//Wizards(each having their own name(string), power level(int), age(int), date of admission in Hogwarts(DateTime), a value for their graduation status(boolean))
//    Creatures(each having their own name(string), age(int), power level(int), information if they have been tamed(boolean))
//Each wizard should be able to duel a creature if the creature has not yet been tamed. If the wizard’s power level is greater than the creature’s power level, they essentially win the duel and that creature is at that moment tamed.

//Main task:
//Create a class for both participants above, and try to determine if the wizard wins the duel.

//Extra task:
//Define separate arrays of wizards and creatures, and determine if all creatures can be tamed by that array of wizards.If there is a creature that no wizard can tame, specify that creature’s name.

namespace Class05.homework
{
    class Program
    {
        static void Main(string[] args)
        {
            //Main Task
            //Wizard harryPotter = new Wizard("Harry Potter", 15, 90000, new DateTime(2001, 5, 2), false);
            //Creature basilisk = new Creature("Basilisk", 3, 6000, false);

            //string duel = DuelCreature(harryPotter, basilisk);
            //Console.WriteLine(duel);


            //Extra Task
            Wizard[] wizards = new Wizard[]
            {
                new Wizard("Harry Potter", 15, 9000, new DateTime(2001, 5, 2), false),
                new Wizard("Hermione Granger", 15, 8000, new DateTime(2001, 5, 2), false),
                new Wizard("Ron Weasley", 15, 3000, new DateTime(2001, 5, 2), false),
                new Wizard("Draco Malfoy", 14, 6500, new DateTime(2000, 6, 1), false),
                new Wizard("Ginny Weasley", 11, 7000, new DateTime(2003, 6, 1), false),
                new Wizard("Lord Voldemort", 11, 8999, new DateTime(1990, 10, 1), false)
            };

            Creature[] creatures = new Creature[]
            {
                new Creature("Basilisk", 3, 6000, false),
                new Creature("Acromantula", 10, 7000, false),
                new Creature("Dementor", 100, 8900, false),
                new Creature("Hippogriff", 8, 3500, false),
                new Creature("Troll", 5, 2000, false),
                new Creature("Black Dragon", 5, 15000, false)
        };

            Wizard bestWizard = Wizard.WizardWithMaxPowerLevel(wizards);

            //Creature bestCreature = Creature.CreatureWithMaxPowerLevel(creatures);


            bool allTamable = true;
            for (int i = 0; i < creatures.Length; i++)
            {
                if(creatures[i].PowerLevel > bestWizard.PowerLevel)
                {
                    allTamable = false;
                    Console.WriteLine($"No wizard can tame {creatures[i]}");
                }
            }
            if (allTamable)
            {
            Console.WriteLine("All creatures can be tamed.");
            }

            Console.ReadLine();
        }


        static string DuelCreature(Wizard wizard, Creature creture)
        {
            string result = string.Empty;
            if (creture.IsTamed)
            {
                result = $"The creature{creture.Name} is already tamed, and you cannot duel it!";
                return result;
            }
            if(wizard.PowerLevel <= creture.PowerLevel)
            {
                result = $"The wizard {wizard.Name} lost the duel! The creature {creture.Name} cannot be tamed.";
                return result;
            }
            creture.IsTamed = true;
            result = $"The creature {creture.Name} has been tamed by the wizard {wizard.Name}";
            return result;
        }
    }
}
