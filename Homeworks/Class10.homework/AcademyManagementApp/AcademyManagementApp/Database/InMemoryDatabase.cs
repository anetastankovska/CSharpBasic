using AcademyManagementApp.Enums;
using AcademyManagementApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyManagementApp.Database
{
    public class InMemoryDatabase
    {
        public List<Admin> Admins { get; set; }
        public List<Trainer> Trainers { get; set; }
        public List<Student> Students { get; set; }

        public void InitDatabase()
        {
            Admins = new List<Admin>
            {
                new Admin("admin1", "admin123", "Aneta", "Stankovska"),
                new Admin("admin2", "admin234", "Stefan", "Ivanocski"),
                new Admin("admin3", "admin345", "Aleksandar", "Zivkovic")
            };

            Trainers = new List<Trainer>
            {
                new Trainer("trainer1", "trainer123", "Trajan", "Stevkovski"),
                new Trainer("trainer2", "trainer234", "Vlatko", "Tasevski"),
                new Trainer("trainer3", "trainer345", "Nikola", "Dalchevski")
            };

            Students = new List<Student>
            {
                new Student("student1", "student123", "Igor", "Nikoloski"),
                new Student("student2", "student234", "Marija", "Kolevska"),
                new Student("student3", "student345", "Ilija", "Mitev"),
                new Student("student4", "student456", "Maja", "Nikolic"),
                new Student("student5", "student567", "Kristijan", "Karanfilovski"),
                new Student("student6", "student678", "Ana", "Kirovska"),
                new Student("student7", "student789", "Slave", "Trajkovski"),
                new Student("student8", "student891", "Timotej", "Bojarovski"),
                new Student("student9", "student912", "Bob", "Bobsky")
            };
        }

        

    }
}
