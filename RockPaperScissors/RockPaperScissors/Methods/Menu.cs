using RockPaperScissors.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissors.Methods
{
    public static class Menu
    {
        public static void MainMenu()
        {
            Console.WriteLine("Rock Paper Scissors Game");
            Console.WriteLine("------------------------");
            

            bool checkChocie = true;
            while (checkChocie)
            {
                int playerScore = 0;
                int computerScore = 0;
                int tieScore = 0;
                int gamesPlayed = 0;
                string playerName = "";

                Console.WriteLine("Choose an option:\n[1] - Play\n[2] - Stats\n[3] - Exit");
                checkChocie = int.TryParse(Console.ReadLine(), out int choice);
                switch (choice)
                {
                    case 1:
                        Play(playerScore, computerScore, tieScore, gamesPlayed, playerName);
                        break;
                    case 2:
                        Stats(playerScore, computerScore, tieScore, gamesPlayed);
                        break;
                    case 3:
                        Console.WriteLine("Thanks for playing. Press enter to exit...");
                        Console.ReadLine();
                        checkChocie = false;
                        break;
                    default:
                        Console.Clear();
                        checkChocie = true;
                        break;
                }
            }
        }

        public static void Play(int playerScore, int computerScore, int tieScore, int gamesPlayed, string playerName)
        {

            bool player = true;
            while (player)
            {
                Console.WriteLine("Enter your name:");
                playerName = Console.ReadLine();
                if (playerName.Length < 2)
                {
                    Console.WriteLine("Enter a valid name");
                    continue;
                }
                else
                {
                    Console.WriteLine($"Welcome {playerName}");
                    player = false;
                }
            }

            bool repeatGame = true;
            while (repeatGame)
            {
                Console.WriteLine("Please choose:\n1. Rock\n2. Paper\n3. Scissors");
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine("When done playing, enter X");
                bool playerChoice = true;
                Choices playerWeapon = Choices.NoChoice;
                while (playerChoice)
                {
                    string choice = Console.ReadLine();
                    switch (choice.ToLower())
                    {
                        case "1":
                            playerWeapon = Choices.Rock;
                            Console.WriteLine($"You chose {playerWeapon}");
                            playerChoice = false;
                            break;
                        case "2":
                            playerWeapon = Choices.Paper;
                            Console.WriteLine($"You chose {playerWeapon}");
                            playerChoice = false;
                            break;
                        case "3":
                            playerWeapon = Choices.Scissors;
                            Console.WriteLine($"You chose {playerWeapon}");
                            playerChoice = false;
                            break;
                        case "x":
                            playerChoice = false;
                            repeatGame = false;
                            break;
                        default:
                            Console.WriteLine("Try entering a valid choice: 1, 2 or 3 allowed only!");
                            Console.ReadLine();
                            playerChoice = true;
                            break;
                    }
                }

                if (repeatGame == true)
                {
                    Console.WriteLine("Press enter to make your opponent choose:");
                    Console.ReadLine();
                    Random randomChoice = new Random();
                    int computerRandomChoice = randomChoice.Next(1, 3);
                    Choices computerWeapon = (Choices)computerRandomChoice;
                    Console.WriteLine($"Computer chose {computerWeapon}");
                    gamesPlayed++;

                    switch (playerWeapon, computerWeapon)
                    {
                        case (Choices.Rock, Choices.Rock):
                            Console.WriteLine("It's a tie!");
                            tieScore++;
                            break;
                        case (Choices.Paper, Choices.Paper):
                            Console.WriteLine("It's a tie!");
                            tieScore++;
                            break;
                        case (Choices.Scissors, Choices.Scissors):
                            Console.WriteLine("It's a tie!");
                            tieScore++;
                            break;
                        case (Choices.Rock, Choices.Paper):
                            Console.WriteLine($"Paper beats Rock, Computer wins!");
                            computerScore++;
                            break;
                        case (Choices.Rock, Choices.Scissors):
                            Console.WriteLine($"Rock beats Scissors, Player1");
                            playerScore++;
                            break;
                        case (Choices.Paper, Choices.Rock):
                            Console.WriteLine($"Paper beats Rock, Player1 wins!");
                            playerScore++;
                            break;
                        case (Choices.Paper, Choices.Scissors):
                            Console.WriteLine($"Scissors beat Paper, Computer wins!");
                            computerScore++;
                            break;
                        case (Choices.Scissors, Choices.Rock):
                            Console.WriteLine($"Rock beats Scissors, Computer wins");
                            computerScore++;
                            break;
                        case (Choices.Scissors, Choices.Paper):
                            Console.WriteLine($"Scissors beat Paper, Player1 wins!");
                            playerScore++;
                            break;
                        default:
                            break;
                    }
                } 
            }            
        }

        public static void Stats(int playerScore, int computerScore, int tieScore, int gamesPlayed)
        {
            Console.WriteLine($"Player1 has {playerScore} wins, Computer has {computerScore}");
            Console.ReadLine();
            //Console.WriteLine($"{playerName} has a {playerScore / gamesPlayed}% of wins, and a {computerScore / gamesPlayed}% losses");
        }

        

        //public static int GetScores()
        //{

        //}
    }
}
