using QuizLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuizServices
{
    public class HelpOptions
    {
        public static bool UsedFiftyFifty { get; set; } = false;
        public static bool UsedAudience { get; set; } = false;
        public static bool UsedCallAFriend { get; set; } = false;

        public static void FiftyFifty(Question question)
        {
            UsedFiftyFifty = true;

            var answer1 = question.AnswerChoices.Where(x => x.Key == Database.CurrentQuestion.CorrectAnswer).FirstOrDefault();
            var answer2 = question.AnswerChoices.Where(x => x.Key != Database.CurrentQuestion.CorrectAnswer).FirstOrDefault();
            Console.WriteLine($"{answer1.Key} - {answer1.Value}\n{answer2.Key} - {answer2.Value}");
        }

        public static void Audience(Question question)
        {
            UsedAudience = true;
            var answers = question.AnswerChoices.ToList();
            foreach (var item in answers)
            {
                if (item.Key == question.CorrectAnswer)
                {
                    Console.WriteLine($"{item.Key} - {item.Value}" + "  70%");
                }
                else
                {
                    Console.WriteLine($"{item.Key} - {item.Value}" + "  10%");
                }
                
            }
        }

        public static void CallAFriend(Question question)
        {
            UsedCallAFriend = true;

            Console.WriteLine($"Firend says: I think it's {Database.CurrentQuestion.CorrectAnswer}");
        }
    }
}
