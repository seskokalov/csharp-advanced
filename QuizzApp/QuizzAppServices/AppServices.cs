using QuizzAppLibrary.Entities.Models;
using QuizzAppLibrary.Entities.Enums;
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
                Console.ForegroundColor = ConsoleColor.White;
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
                            Database.activeSessionTeacher(teacher);
                            Console.ReadLine();
                            TeacherService.CheckQuiz(teachers, students);
                        }
                    }
                    foreach (Student student in students)
                    {
                        if (student.Username == username && student.Password == password)
                        {
                            if (student.TestGrade != Grades.NoGrade)
                            {
                                Console.WriteLine("Already did the test, nice try :)");
                                Console.ReadLine();
                            }
                            else
                            {
                                Console.BackgroundColor = ConsoleColor.DarkGreen;
                                Console.ForegroundColor = ConsoleColor.Black;
                                loginAttempts = 0;
                                Console.WriteLine($"Welcome {student.FirstName} {student.LastName}");
                                Database.activeSessionStudent(student);
                                Console.ReadLine();
                                StudentService.QuizTime();
                            }
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

