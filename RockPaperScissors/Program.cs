using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            
            while (true)
            {
                //INITIAL RUN OF THE METHOD
                char continuePlaying = 'z';
                PlayRockPaperScissors();
                //DEFINITION OF THE METHOD
                void PlayRockPaperScissors()
                {
                    //PROMTS FOR THE NUMBER OF PLAYS
                    int numberOfPlays;
                    while (true)
                    {
                        Console.WriteLine("How many rounds of Rock, Paper, Scissors would you like to play? Please choose between 1 and 10.");
                        string input = Console.ReadLine();

                        if (int.TryParse(input, out numberOfPlays) && numberOfPlays > 0 && numberOfPlays <= 10)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Please enter a whole number between 1 and 10.");
                        }
                    }

                    //PROMPTS FOR USER ROLL AND COMPUTER ROLL
                    int numberOfTies = 0;
                    int numberOfUserWins = 0;
                    int numberOfComputerWins = 0;

                    Random randomizer = new Random();
                    for (int i = 1; i <= numberOfPlays; i++)
                    {
                        int userRoll;
                        while (true)
                        {
                            Console.WriteLine("Rock (1), Paper (2), or Scissors (3)?");
                            string input = Console.ReadLine();

                            if (int.TryParse(input, out userRoll) && userRoll > 0 && userRoll <= 3)
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Please enter a whole number for rock (1), paper (2), or scissors (3).");
                            }
                        }

                        //POSSIBLE ROLLS
                        int computerRoll = randomizer.Next(1, 3);
                        if (userRoll == computerRoll)
                        {
                            Console.WriteLine("Its a tie! No one wins.");
                            numberOfTies++;
                        }
                        if (userRoll == 1 && computerRoll == 2)
                        {
                            Console.WriteLine("Paper beats Rock! Computer wins!");
                            numberOfComputerWins++;
                        }
                        if (userRoll == 1 && computerRoll == 3)
                        {
                            Console.WriteLine("Rock beats scissors! User wins!");
                            numberOfUserWins++;
                        }
                        if (userRoll == 2 && computerRoll == 1)
                        {
                            Console.WriteLine("Paper beats rock! User wins!");
                            numberOfUserWins++;
                        }
                        if (userRoll == 2 && computerRoll == 3)
                        {
                            Console.WriteLine("Scissors beats paper! Computer wins!");
                            numberOfComputerWins++;
                        }
                        if (userRoll == 3 && computerRoll == 1)
                        {
                            Console.WriteLine("Rock beats scissors! Computer wins!");
                            numberOfComputerWins++;
                        }
                        if (userRoll == 3 && computerRoll == 2)
                        {
                            Console.WriteLine("Scissors beats paper! User wins!");
                            numberOfUserWins++;
                        }
                    }

                    //OUTPUT FOR WHOMEVER WON THE GAME
                    Console.WriteLine("");
                    if (numberOfUserWins == numberOfComputerWins)
                    {
                        Console.WriteLine("It was a tie! No one won :(");
                    }
                    if (numberOfUserWins > numberOfComputerWins)
                    {
                        Console.WriteLine("The user won! Congrats!");
                    }
                    if (numberOfUserWins < numberOfComputerWins)
                    {
                        Console.WriteLine("The comptuter won! Yikes...");
                    }

                    Console.WriteLine("Number of ties: " + numberOfTies);
                    Console.WriteLine("Number of user wins: " + numberOfUserWins);
                    Console.WriteLine("Number of computer wins: " + numberOfComputerWins);
                    Console.WriteLine("");

                    //PLAY AGAIN PROMPT
                    while (true)
                    {
                        char playAgain;
                        Console.WriteLine("Would you like to play again?");
                        string input = Console.ReadLine();

                        if (char.TryParse(input, out playAgain) && playAgain == 'y' || playAgain == 'n')
                        {
                            continuePlaying = playAgain;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Please enter \"y\" or \"n\" for yes and no respectively.");
                        }
                    }
                }
                //CONDITIONALS FOR PLAYING AGAIN
                if (continuePlaying == 'y')
                {
                    PlayRockPaperScissors();
                }
                if (continuePlaying == 'n')
                {
                    Console.WriteLine("Thanks for playing!");
                    break;
                }
            }
        }
    }
}
