using System;
using System.Collections.Generic;
using System.Text;

namespace QuizLibrary
{
    public class Question
    {
        public string QuestionDescription { get; set; }
        public string CorrectAnswer { get; set; }
        public string SelectedAnswer { get; set; }
        public Dictionary<string, string> AnswerChoices { get; set; }

        public Question()
        {

        }

        public Question(string question, string correctAnswer, Dictionary<string, string> answerChoices)
        {
            QuestionDescription = question;
            CorrectAnswer = correctAnswer;
            AnswerChoices = answerChoices;
        }
    }
}
