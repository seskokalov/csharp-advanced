using QuizLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuizServices
{
    public static class Database
    {
        public static string PlayerName { get; set; }
        public static Question CurrentQuestion { get; set; }
        public static string CurrentAnswer { get; set; }

        public static void SelectedPlayerName(string name)
        {
            PlayerName = name;
        }

        public static void ActiveQuestion(Question question)
        {
            CurrentQuestion = question;
        }

        public static void Answer(string answer)
        {
            CurrentAnswer = answer;
        }
    }
}
