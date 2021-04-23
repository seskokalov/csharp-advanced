using System;
using System.Collections.Generic;
using System.Text;

namespace QuizzAppServices
{
    public static class StudentService
    {
        public static void QuizTime()
        {
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

            }
            else
            {

            }

            Console.Clear();
            bool secondQuestionCheck = true;
            string secondQuestionAnswer = "";

            Console.WriteLine("Q: What is the tallest building in the Republic of the Congo?\na: Kinshasa Democratic Republic of the Congo Temple\nb: Palais de la Nation\nc: Kongo Trade Centre\nd: Nabemba Tower");

            while (secondQuestionCheck)
            {
                secondQuestionAnswer = Console.ReadLine();
                if (secondQuestionAnswer.ToLower() != "a" || secondQuestionAnswer.ToLower() != "b" || secondQuestionAnswer.ToLower() != "c" || secondQuestionAnswer.ToLower() != "d")
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

            }
            else
            {

            }
        }
    }
}
