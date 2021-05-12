using QuizLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using WMPLib;
using System.Media;

namespace QuizMain
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();

            #region Questions
            List<Question> firstRoundQuestions = new List<Question>()
            {
                new Question("In the UK, the abbreviation NHS stands for National what Service?", "B", new Dictionary<string, string>
                {
                    { "A", "Humanity" },
                    { "B", "Health" },
                    { "C", "Honor" },
                    { "D", "Household" }
                }),
                new Question("Since 2011, Brendan O’Carroll has played the title character in what sitcom?", "A", new Dictionary<string, string>
                {
                    { "A", "Mrs. Brown’s Boys" },
                    { "B", "Mrs. Brown’s Babes" },
                    { "C", "Mrs. Brown’s Baboons" },
                    { "D", "Mrs. Brown’s Bust Ups" }
                }),
                new Question("Which of these is a breed of spaniel?", "C", new Dictionary<string, string>
                {
                    { "A", "King James" },
                    { "B", "King John" },
                    { "C", "King Charles" },
                    { "D", "King George" }
                }),
                new Question("According to Robert Burns, which food is the “Great chieftain o’ the pudding-race”?", "B", new Dictionary<string, string>
                {
                    { "A", "Teacake" },
                    { "B", "Haggis" },
                    { "C", "Bacon roll" },
                    { "D", "Sticky toffee pudding" }
                }),
                new Question("What is the name of the character played by Daisy Ridley in ‘Star Wars: The Rise of Skywalker’?", "B", new Dictionary<string, string>
                {
                    { "A", "Doh" },
                    { "B", "Rey" },
                    { "C", "Mee" },
                    { "D", "Farr" }
                }),
                new Question("Which of these is the title of a famous artwork by Tracey Emin?", "D", new Dictionary<string, string>
                {
                    { "A", "Our Settee" },
                    { "B", "Your Bench" },
                    { "C", "Her Desk" },
                    { "D", "My Bed" }
                }),
                new Question("The annual half-marathon the Great North Run starts in which UK city?", "A", new Dictionary<string, string>
                {
                    { "A", "Newcastle " },
                    { "B", "Sheffield " },
                    { "C", "Liverpool " },
                    { "D", "Leeds " }
                }),
                new Question("For what reason did Professor Robert Kelly gain internet fame in 2017?", "C", new Dictionary<string, string>
                {
                    { "A", "Mistaken identity on news " },
                    { "B", "Chasing after his dog " },
                    { "C", "Kids gatecrashed interview " },
                    { "D", "Trying to catch a bat " }
                }),
                new Question("A character named Ralph is elected leader of a group of boys at the beginning of which book?", "A", new Dictionary<string, string>
                {
                    { "A", "Lord of the Flies" },
                    { "B", "A Clockwork Orange" },
                    { "C", "The Jungle Book" },
                    { "D", "Brave New World" }
                }),
            };

            List<Question> secondRoundQuestions = new List<Question>()
            {
                new Question("A spork is a utensil that typically combines a fork with which other item?", "C", new Dictionary<string, string>
                {
                    { "A", "Colander " },
                    { "B", "Whisk " },
                    { "C", "Spoon " },
                    { "D", "Corkscrew " }
                }),
                new Question("Which of these is regarded as a national symbol of Canada?", "A", new Dictionary<string, string>
                {
                    { "A", "Maple Leaf " },
                    { "B", "Fig Leaf " },
                    { "C", "Fern Leaf " },
                    { "D", "Tea Leaf " }
                }),
                new Question(@"Someone expressing anger is said to be ‘venting their… ‘ what?", "A", new Dictionary<string, string>
                {
                    { "A", "Spleen " },
                    { "B", "Liver " },
                    { "C", "Intestines " },
                    { "D", "Pancreas " }
                }),
                new Question("In the novel ‘The Lord of The Rings’, Frodo, Sam and Bilbo come from which region of Middle Earth?", "B", new Dictionary<string, string>
                {
                    { "A", "The Green " },
                    { "B", "The Borough " },
                    { "C", "The Shire " },
                    { "D", "The City " }
                }),
                new Question("The name of which of these types of sausage is derived from that of a German city?", "D", new Dictionary<string, string>
                {
                    { "A", "Salami " },
                    { "B", "Cumberland " },
                    { "C", "Chorizo " },
                    { "D", "Frankfurter " }
                })
            };

            List<Question> thirdRoundQuestions = new List<Question>()
            {
                new Question("Which of these is most likely to be used by an archer?", "B", new Dictionary<string, string>
                {
                    { "A", "Bitterbow " },
                    { "B", "Crossbow " },
                    { "C", "Furiousbow " },
                    { "D", "Iratebow " }
                }),
                new Question(@"A controversial situation which is awkward to deal with is often referred to as a ‘hot …’ what?", "C", new Dictionary<string, string>
                {
                    { "A", "Leek " },
                    { "B", "Onion " },
                    { "C", "Potato " },
                    { "D", "Tomato " }
                }),
                new Question(@"In 1987, Whitney Houston topped the UK singles chart with ‘I Wanna…’ what ‘With Somebody’?", "B", new Dictionary<string, string>
                {
                    { "A", "Sing " },
                    { "B", "Dance " },
                    { "C", "Spend time " },
                    { "D", "Have a cuddle " }
                }),
                new Question("Something that gives away the plot or outcome of a TV show is called a… what?", "D", new Dictionary<string, string>
                {
                    { "A", "Fender " },
                    { "B", "Splitter " },
                    { "C", "Muffler " },
                    { "D", "Spoiler " }
                }),
                new Question("What colour is the head of an adult male mallard?", "D", new Dictionary<string, string>
                {
                    { "A", "Brown " },
                    { "B", "Red " },
                    { "C", "Black " },
                    { "D", "Green " }
                }),
            };

            List<Question> shuffledFirstRoundQuestions = firstRoundQuestions.OrderBy(x => Guid.NewGuid()).ToList();
            List<Question> shuffledSecondRoundQuestions = secondRoundQuestions.OrderBy(x => Guid.NewGuid()).ToList();
            List<Question> shuffledThirdRoundQuestions = thirdRoundQuestions.OrderBy(x => Guid.NewGuid()).ToList();


            #endregion

            QuizServices.Sound.ContestantName().Play();

            while (true)
            {
                Console.WriteLine("Enter your name to start the quiz!");
                string player1 = Console.ReadLine();
                if (player1.Length < 2)
                {
                    Console.WriteLine("Enter a valid name!");
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine($"Welcome {player1}!");
                    QuizServices.Database.SelectedPlayerName(player1);
                    Console.WriteLine("-------------------------------");
                    Console.WriteLine("Next up, the rules of the quiz. Press Enter to view them.");
                    QuizServices.Validations.PressKeyToContinue();
                    break;
                }
            }

            #region Rules
            Console.Clear();
            QuizServices.Sound.ContestantName().Stop();
            QuizServices.Sound.Rules().Play();
            Console.WriteLine("Rules are simple, question is displayed with four possible answers, only one is correct. \nAswer by entering A, B, C or D depending on the correct answer.\nChoose J for a lifeline, or choose Q to quit\nNo time limit, but please don't take forever :) \nYou have three lifelines to help you, you can use each only once! Lifelines are 50-50, Ask the audience or Get help from a friend.");
            Console.WriteLine("---------------------");
            Console.WriteLine("GOOD LUCK!");
            Console.WriteLine("---------------------");
            QuizServices.Validations.PressKeyToContinue();
            #endregion

            #region GameTime
            bool stillPlaying = true;

            while (stillPlaying)
            {
                #region first round
                QuizServices.Questions.NextQuestion(shuffledFirstRoundQuestions[0]);
                QuizServices.Database.ActiveQuestion(shuffledFirstRoundQuestions[0]);
                QuizServices.Sound.LetsPlay().PlaySync();
                QuizServices.Sound.Question().PlayLooping();
                QuizServices.Validations.QuestionInputValidate();
                QuizServices.Validations.QuestionChoice(QuizServices.Database.CurrentQuestion, QuizServices.Database.CurrentAnswer);

                QuizServices.Questions.NextQuestion(shuffledFirstRoundQuestions[1]);
                QuizServices.Database.ActiveQuestion(shuffledFirstRoundQuestions[1]);
                QuizServices.Sound.LetsPlay().PlaySync();
                QuizServices.Sound.Question().PlayLooping();
                QuizServices.Validations.QuestionInputValidate();
                QuizServices.Validations.QuestionChoice(QuizServices.Database.CurrentQuestion, QuizServices.Database.CurrentAnswer);

                QuizServices.Questions.NextQuestion(shuffledFirstRoundQuestions[2]);
                QuizServices.Database.ActiveQuestion(shuffledFirstRoundQuestions[2]);
                QuizServices.Sound.LetsPlay().PlaySync();
                QuizServices.Sound.Question().PlayLooping();
                QuizServices.Validations.QuestionInputValidate();
                QuizServices.Validations.QuestionChoice(QuizServices.Database.CurrentQuestion, QuizServices.Database.CurrentAnswer);

                QuizServices.Questions.NextQuestion(shuffledFirstRoundQuestions[3]);
                QuizServices.Database.ActiveQuestion(shuffledFirstRoundQuestions[3]);
                QuizServices.Sound.LetsPlay().PlaySync();
                QuizServices.Sound.Question().PlayLooping();
                QuizServices.Validations.QuestionInputValidate();
                QuizServices.Validations.QuestionChoice(QuizServices.Database.CurrentQuestion, QuizServices.Database.CurrentAnswer);

                QuizServices.Questions.NextQuestion(shuffledFirstRoundQuestions[4]);
                QuizServices.Database.ActiveQuestion(shuffledFirstRoundQuestions[4]);
                QuizServices.Sound.LetsPlay().PlaySync();
                QuizServices.Sound.Question().PlayLooping();
                QuizServices.Validations.QuestionInputValidate();
                QuizServices.Validations.QuestionChoice(QuizServices.Database.CurrentQuestion, QuizServices.Database.CurrentAnswer);
                #endregion

                #region second round
                QuizServices.Questions.NextQuestion(shuffledSecondRoundQuestions[0]);
                QuizServices.Database.ActiveQuestion(shuffledSecondRoundQuestions[0]);
                QuizServices.Sound.LetsPlay().PlaySync();
                QuizServices.Sound.Question().PlayLooping();
                QuizServices.Validations.QuestionInputValidate();
                QuizServices.Validations.QuestionChoice(QuizServices.Database.CurrentQuestion, QuizServices.Database.CurrentAnswer);

                QuizServices.Questions.NextQuestion(shuffledSecondRoundQuestions[1]);
                QuizServices.Database.ActiveQuestion(shuffledSecondRoundQuestions[1]);
                QuizServices.Sound.LetsPlay().PlaySync();
                QuizServices.Sound.Question().PlayLooping();
                QuizServices.Validations.QuestionInputValidate();
                QuizServices.Validations.QuestionChoice(QuizServices.Database.CurrentQuestion, QuizServices.Database.CurrentAnswer);

                QuizServices.Questions.NextQuestion(shuffledSecondRoundQuestions[2]);
                QuizServices.Database.ActiveQuestion(shuffledSecondRoundQuestions[2]);
                QuizServices.Sound.LetsPlay().PlaySync();
                QuizServices.Sound.Question().PlayLooping();
                QuizServices.Validations.QuestionInputValidate();
                QuizServices.Validations.QuestionChoice(QuizServices.Database.CurrentQuestion, QuizServices.Database.CurrentAnswer);

                QuizServices.Questions.NextQuestion(shuffledSecondRoundQuestions[3]);
                QuizServices.Database.ActiveQuestion(shuffledSecondRoundQuestions[3]);
                QuizServices.Sound.LetsPlay().PlaySync();
                QuizServices.Sound.Question().PlayLooping();
                QuizServices.Validations.QuestionInputValidate();
                QuizServices.Validations.QuestionChoice(QuizServices.Database.CurrentQuestion, QuizServices.Database.CurrentAnswer);

                QuizServices.Questions.NextQuestion(shuffledSecondRoundQuestions[4]);
                QuizServices.Database.ActiveQuestion(shuffledSecondRoundQuestions[4]);
                QuizServices.Sound.LetsPlay().PlaySync();
                QuizServices.Sound.Question().PlayLooping();
                QuizServices.Validations.QuestionInputValidate();
                QuizServices.Validations.QuestionChoice(QuizServices.Database.CurrentQuestion, QuizServices.Database.CurrentAnswer);
                #endregion

                #region third round
                QuizServices.Questions.NextQuestion(shuffledThirdRoundQuestions[0]);
                QuizServices.Database.ActiveQuestion(shuffledThirdRoundQuestions[0]);
                QuizServices.Sound.LetsPlay().PlaySync();
                QuizServices.Sound.Question().PlayLooping();
                QuizServices.Validations.QuestionInputValidate();
                QuizServices.Validations.QuestionChoice(QuizServices.Database.CurrentQuestion, QuizServices.Database.CurrentAnswer);

                QuizServices.Questions.NextQuestion(shuffledThirdRoundQuestions[1]);
                QuizServices.Database.ActiveQuestion(shuffledThirdRoundQuestions[1]);
                QuizServices.Sound.LetsPlay().PlaySync();
                QuizServices.Sound.Question().PlayLooping();
                QuizServices.Validations.QuestionInputValidate();
                QuizServices.Validations.QuestionChoice(QuizServices.Database.CurrentQuestion, QuizServices.Database.CurrentAnswer);

                QuizServices.Questions.NextQuestion(shuffledThirdRoundQuestions[2]);
                QuizServices.Database.ActiveQuestion(shuffledThirdRoundQuestions[2]);
                QuizServices.Sound.LetsPlay().PlaySync();
                QuizServices.Sound.Question().PlayLooping();
                QuizServices.Validations.QuestionInputValidate();
                QuizServices.Validations.QuestionChoice(QuizServices.Database.CurrentQuestion, QuizServices.Database.CurrentAnswer);

                QuizServices.Questions.NextQuestion(shuffledThirdRoundQuestions[3]);
                QuizServices.Database.ActiveQuestion(shuffledThirdRoundQuestions[3]);
                QuizServices.Sound.LetsPlay().PlaySync();
                QuizServices.Sound.Question().PlayLooping();
                QuizServices.Validations.QuestionInputValidate();
                QuizServices.Validations.QuestionChoice(QuizServices.Database.CurrentQuestion, QuizServices.Database.CurrentAnswer);

                QuizServices.Questions.NextQuestion(shuffledThirdRoundQuestions[4]);
                QuizServices.Database.ActiveQuestion(shuffledThirdRoundQuestions[4]);
                QuizServices.Sound.LetsPlay().PlaySync();
                QuizServices.Sound.Question().PlayLooping();
                QuizServices.Validations.QuestionInputValidate();
                QuizServices.Validations.QuestionChoice(QuizServices.Database.CurrentQuestion, QuizServices.Database.CurrentAnswer);

                Console.WriteLine("CONGRATULATIONS on winning 1.000.000$!!!!");
                Console.ReadLine();
                #endregion
            }
        }
        #endregion
    }
}
