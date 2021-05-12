using QuizLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WMPLib;

namespace QuizServices
{
    public static class Questions
    {
        public static void NextQuestion(Question question)
        {
            Console.Clear();

            Console.WriteLine(question.QuestionDescription);
            var answers = question.AnswerChoices.ToList();
            foreach (var item in answers)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
        }
                
    }
}
