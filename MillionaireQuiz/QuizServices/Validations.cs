using QuizLibrary;
using System;
using System.Collections.Generic;
using System.Text;
using WMPLib;

namespace QuizServices
{
    public static class Validations
    {
        public static void PressKeyToContinue()
        {
            char key = Console.ReadKey(true).KeyChar;
        }

        public static void QuestionInputValidate()
        {
            bool validAnswer = true;
            while (validAnswer)
            {
                char answerChar = Console.ReadKey().KeyChar;
                string answer = answerChar.ToString().ToUpper();

                if (answer != "A" && answer != "B" && answer != "C" && answer != "D" && answer != "J" && answer != "Q")
                {
                    Console.WriteLine("That's not a valid answer, try again");
                }
                else
                {
                    if (answer == "A" || answer == "B" || answer == "C" || answer == "D")
                    {
                        QuizServices.Database.Answer(answer);
                        validAnswer = false;
                    }
                    else if (answer == "J")
                    {
                        Console.WriteLine("1 - 50/50\n2 - Ask the audience\n3 - Call a friend");
                        bool joker = int.TryParse(Console.ReadLine(), out int helpChoice);
                        switch (helpChoice)
                        {
                            case 1:
                                if (HelpOptions.UsedFiftyFifty == true)
                                {
                                    Console.WriteLine("Can't use again!");
                                }
                                else
                                {
                                    HelpOptions.FiftyFifty(QuizServices.Database.CurrentQuestion);
                                }
                                break;
                            case 2:
                                if (HelpOptions.UsedAudience == true)
                                {
                                    Console.WriteLine("Can't use again!");
                                }
                                else
                                {
                                    HelpOptions.Audience(QuizServices.Database.CurrentQuestion);
                                }                                
                                break;
                            case 3:
                                if (HelpOptions.UsedCallAFriend == true)
                                {
                                    Console.WriteLine("Can't use again!");
                                }
                                else
                                {
                                    HelpOptions.CallAFriend(Database.CurrentQuestion);
                                }
                                break;
                            default:
                                Console.WriteLine("Invalid choice");
                                break;
                        }

                    }
                    else
                    {
                        Console.WriteLine("Thank you for playing!!!");
                        PressKeyToContinue();
                        Environment.Exit(0);
                    }
                }
            }
        }

        public static void QuestionChoice(Question question, string answer)
        {
            Sound.FinalAnswer().Play();
            Console.WriteLine("Is that your final answer?");
            char finalAnswer = Console.ReadKey().KeyChar;

            if (finalAnswer == 'n')
            {
                Console.WriteLine("Enter a new answer:");
                QuestionInputValidate();
                QuestionChoice(question, answer);
            }
            else if (finalAnswer == 'y')
            {
                if (answer == question.CorrectAnswer)
                {                    
                    Console.WriteLine("Good answer");
                    Sound.GoodAnswer().PlaySync();
                }
                else
                {
                    Console.WriteLine("Wrong answer! Game over!");
                    Sound.WrongAnswer().PlaySync();
                    PressKeyToContinue();
                    Environment.Exit(0);
                }
            }
        }           
    }
}
