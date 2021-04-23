using QuizzAppLibrary.Entities.Models;
using QuizzAppLibrary.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuizzAppServices
{
    public static class TeacherService
    {
        public static void CheckQuiz(List<Teacher> teacher, List<Student> students)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("These are the results of the student quiz test. Come back later for more results...");
            int studentCounter = 0;
            foreach (Student item in students)
            {
                studentCounter++;
                if (item.TestGrade == Grades.NoGrade)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{studentCounter} - {item.FirstName} {item.LastName}, yet to do the quiz or skip workshop");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"{studentCounter} - {item.FirstName} {item.LastName} - Grade: {item.TestGrade}");
                }
            }
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Press any key to continue.....");
            Console.ReadLine();
        }
    }
}
