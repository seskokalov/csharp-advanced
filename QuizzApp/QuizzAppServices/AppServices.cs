using QuizzAppLibrary.Entities.Models;
using QuizzAppServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuizzAppServices
{
    public static class AppServices
    {
        public static void MainMenu(List<Teacher> teachers, List<Student> students)
        {
            int loginAttempts = 0;
            bool loginCheck = true;
            while (loginCheck)
            {                
                Console.WriteLine("Enter your username:");
                string username = Console.ReadLine();
                Console.WriteLine("Enter your password:");
                string password = Console.ReadLine();
                loginAttempts++;
                if (loginAttempts == 4)
                {
                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Maximum attepmts reached... Application will now terminate");
                    Console.ReadLine();
                    Environment.Exit(0);
                }
                else
                {
                    foreach (Teacher teacher in teachers)
                    {
                        if (teacher.Username == username && teacher.Password == password)
                        {
                            Console.BackgroundColor = ConsoleColor.DarkBlue;
                            Console.ForegroundColor = ConsoleColor.Black;
                            loginAttempts = 0;
                            Console.WriteLine($"Welcome {teacher.FirstName} {teacher.LastName}");
                            
                            Console.ReadLine();
                        }
                    }
                    foreach (Student student in students)
                    {
                        if (student.Username == username && student.Password == password)
                        {
                            Console.BackgroundColor = ConsoleColor.DarkGreen;
                            Console.ForegroundColor = ConsoleColor.Black;
                            loginAttempts = 0;
                            Console.WriteLine($"Welcome {student.FirstName} {student.LastName}");
                            activeSessionStudent(student);
                            Console.ReadLine();
                            StudentService.QuizTime();
                        }
                    }
                    if (loginAttempts == 1)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine($"That was login attempt #{loginAttempts}");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else if (loginAttempts == 2)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine($"Careful!! That was login attempt #{loginAttempts}. One more left.");
                        Console.ForegroundColor = ConsoleColor.White;
                    }                   
                }
            }
        }                
    }
}

