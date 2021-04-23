using System;
using System.Collections.Generic;
using System.Text;
using QuizzAppLibrary.Entities.Enums;
using QuizzAppLibrary.Entities.Models;

namespace QuizzAppServices
{
    public static class StudentService
    {
        public static void QuizTime()
        {
            Console.WriteLine($"{Database.ActiveStudent.FirstName}...");
            Console.WriteLine("This is a simple quiz, answer by typing in the letter (a, b, c or d) of the correct answer");
            Console.WriteLine("------------------------------------------------------------------------------------------");

            bool firstQuestionCheck = true;
            string firstQuestionAnswer = "";

            Console.WriteLine("Q: What is the capital of Tasmania?\na: Dodoma\nb: Hobart\nc: Launceston\nd: Wellington");
            while (firstQuestionCheck)
            {
                firstQuestionAnswer = Console.ReadLine();
                if (firstQuestionAnswer.ToLower() != "a" && firstQuestionAnswer.ToLower() != "b" && firstQuestionAnswer.ToLower() != "c" && firstQuestionAnswer.ToLower() != "d")
                {
                    Console.WriteLine("That's not a valid answer, try again!");
                    firstQuestionCheck = true;
                }
                else
                {
                    firstQuestionCheck = false;
                }
            }
            if (firstQuestionAnswer == "b")
            {
                Database.ActiveStudent.Answers.Add(Answers.GoodAnswer);
            }
            
            Console.Clear();
            bool secondQuestionCheck = true;
            string secondQuestionAnswer = "";

            Console.WriteLine("Q: What is the tallest building in the Republic of the Congo?\na: Kinshasa Democratic Republic of the Congo Temple\nb: Palais de la Nation\nc: Kongo Trade Centre\nd: Nabemba Tower");

            while (secondQuestionCheck)
            {
                secondQuestionAnswer = Console.ReadLine();
                if (secondQuestionAnswer.ToLower() != "a" && secondQuestionAnswer.ToLower() != "b" && secondQuestionAnswer.ToLower() != "c" && secondQuestionAnswer.ToLower() != "d")
                {
                    Console.WriteLine("That's not a valid answer, try again!");
                    secondQuestionCheck = true;
                }
                else
                {
                    secondQuestionCheck = false;
                }
            }
            if (secondQuestionAnswer == "d")
            {
                Database.ActiveStudent.Answers.Add(Answers.GoodAnswer);
            }
            
            Console.Clear();
            bool thirdQuestionCheck = true;
            string thirdQuestionAnswer = "";

            Console.WriteLine("Q: Which of these is not one of Pluto's moons?\na: Styx\nb: Hydra\nc: Nix\nd: Lugia");

            while (thirdQuestionCheck)
            {
                thirdQuestionAnswer = Console.ReadLine();
                if (thirdQuestionAnswer.ToLower() != "a" && thirdQuestionAnswer.ToLower() != "b" && thirdQuestionAnswer.ToLower() != "c" && thirdQuestionAnswer.ToLower() != "d")
                {
                    Console.WriteLine("That's not a valid answer, try again!");
                    thirdQuestionCheck = true;
                }
                else
                {
                    thirdQuestionCheck = false;
                }
            }
            if (thirdQuestionAnswer == "c")
            {
                Database.ActiveStudent.Answers.Add(Answers.GoodAnswer);
            }
            
            Console.Clear();
            bool fourthQuestionCheck = true;
            string fourthQuestionAnswer = "";

            Console.WriteLine("Q: What is the smallest lake in the world?\na: Onega Lake\nb: Benxi Lake\nc: Kivu Lake\nd: Wakatipu Lake");

            while (fourthQuestionCheck)
            {
                fourthQuestionAnswer = Console.ReadLine();
                if (fourthQuestionAnswer.ToLower() != "a" && fourthQuestionAnswer.ToLower() != "b" && fourthQuestionAnswer.ToLower() != "c" && fourthQuestionAnswer.ToLower() != "d")
                {
                    Console.WriteLine("That's not a valid answer, try again!");
                    fourthQuestionCheck = true;
                }
                else
                {
                    fourthQuestionCheck = false;
                }
            }
            if (fourthQuestionAnswer == "b")
            {
                Database.ActiveStudent.Answers.Add(Answers.GoodAnswer);
            }
            
            Console.Clear();
            bool fifthQuestionCheck = true;
            string fifthQuestionAnswer = "";

            Console.WriteLine("Q: What country has the largest population of alpacas?\na: Chad\nb: Peru\nc: Australia\nd: Niger");

            while (fifthQuestionCheck)
            {
                fifthQuestionAnswer = Console.ReadLine();
                if (fifthQuestionAnswer.ToLower() != "a" && fifthQuestionAnswer.ToLower() != "b" && fifthQuestionAnswer.ToLower() != "c" && fifthQuestionAnswer.ToLower() != "d")
                {
                    Console.WriteLine("That's not a valid answer, try again!");
                    fifthQuestionCheck = true;
                }
                else
                {
                    fifthQuestionCheck = false;
                }
            }
            if (fifthQuestionAnswer == "b")
            {
                Database.ActiveStudent.Answers.Add(Answers.GoodAnswer);
            }

            int countGoodAnswers = Database.ActiveStudent.Answers.Count;
            switch (countGoodAnswers)
            {
                case 0:
                    Database.ActiveStudent.TestGrade = Grades.F;
                    break;
                case 1:
                    Database.ActiveStudent.TestGrade = Grades.E;
                    break;
                case 2:
                    Database.ActiveStudent.TestGrade = Grades.D;
                    break;
                case 3:
                    Database.ActiveStudent.TestGrade = Grades.C;
                    break;
                case 4:
                    Database.ActiveStudent.TestGrade = Grades.B;
                    break;
                case 5:
                    Database.ActiveStudent.TestGrade = Grades.A;
                    break;
                default:
                    break;
            }

            Database.ActiveStudent.Answers.Clear();
            Console.WriteLine($"Test result: {Database.ActiveStudent.TestGrade}");
            Console.ReadLine();
            Console.BackgroundColor = ConsoleColor.Black;            
        }
    }
}
