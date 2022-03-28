using SEDC.Oop.Class09.ErrorHandling.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Oop.Class09.ErrorHandling.Services
{
    public class HumanService
    {
        public List<Human> Humans { get; set; }

        public HumanService()
        {
            Humans = new List<Human>
            {
                new Human(){Name = "H1"},
                new Human(){Name = "H2", Skills = new List<Skill>{ new Skill() { Points = 5, Name = "S1"} } },
                new Human(){Name = "H3", Skills = new List<Skill>() }
            };
        }

        public void PrintHumanSkills(Human human)
        {
            try
            {
                foreach (Skill skill in human.Skills)
                {
                    Console.WriteLine(skill.Name);
                }
            }
            catch(NullReferenceException ex)
            {
                throw ex;
            }
        }

        public Skill GetFirstHumanSkill(Human human)
        {
            try
            {
                return human.Skills.First();
            }
            catch(InvalidOperationException ex)
            {
                throw new Exception("There is no skills in this human");
            } 
            catch (Exception)
            {
                throw new Exception("Something wrong has happened");
            }
        }

    }

    
}
