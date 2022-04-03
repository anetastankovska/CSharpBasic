using AcademyManagementApp.Models;
using AcademyManagementApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace AcademyManagementApp
{
    class Program
    {
        static void Main(string[] args)
        {
            AcademyService service = new AcademyService();
            service.InitializeData();

            Person activeUser = null;
            string activeUserStr = string.Empty;

            //Main menu
            while (true)
            {
                Console.Clear();
                string info = "Welcome to the academy management app. \nPlease choose an option below.";
                info += "\n1. Admin user \n2. Trainer user \n3. Student user \n4. Exit";
                int selectedOption = service.ShowMenu(info, 1, 4);
                if (selectedOption == 4)
                {
                    return;
                }
                if (selectedOption < 1 || selectedOption > 4)
                {
                    Console.WriteLine("Wrong option");
                    Thread.Sleep(2000);
                    continue;
                }
                activeUser = service.Login();
                if (activeUser != null)
                {
                    activeUserStr = service.TypeOfPerson(activeUser);
                    Console.WriteLine($"Welcome {activeUser.FirstName} {activeUser.LastName} ({activeUserStr})");
                    Thread.Sleep(2000);
                    break;
                }
            }

            switch (activeUserStr)
            {
                //Switch case for Admin
                case "Admin":
                    Admin admin = activeUser as Admin;
                    Console.Clear();
                    int selectedOption = service.ShowMenu("Please select if you want to add or remove user. \n1. Add user \n2. Remove user", 1, 2);
                    while (true)
                    {
                        if (selectedOption == 1)
                        {
                            admin.AddPerson();
                            break;
                        }
                        if (selectedOption == 2)
                        {
                            try
                            {
                                admin.RemovePerson();
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                                Thread.Sleep(2000);
                                continue;
                            }

                            break;
                        }
                        else
                        {
                            continue;
                        }
                    }
                    break;
                //Switch case for Trainer
                case "Trainer":
                    Trainer trainer = activeUser as Trainer;
                    Console.Clear();
                    while (true)
                    {
                        Console.Clear();
                        int selectedOption1 = service.ShowMenu("Please select what you wish to read: \n1. Students \n2. Subjects", 1, 2);
                        if (selectedOption1 == 1)
                        {
                            Student selected = trainer.ReadStudents();
                            trainer.ReadStudentSubject(selected);
                            break;
                        }
                        if (selectedOption1 == 2)
                        {
                            trainer.ReadSubjects();
                            break;
                        }
                        else
                        {
                            continue;
                        }
                    }
                    break;
                //Switch case for student
                case "Student":
                    Student student = activeUser as Student;
                    Console.Clear();
                    Console.WriteLine(student.ToString());
                    break;
                default:
                    break;
            }
        }
    }
}
