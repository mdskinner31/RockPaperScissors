using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace RockPaperScissors
{
    class RockPaperScissors
    {
        static void Main(string[] args)
        {
            string playerInput;
            int randInt;
            string cpuInput;
            bool playAgain = true;

            Console.WriteLine("Lets play ROCK PAPER SCISSORS! Best three out of five to win!!");

            while (playAgain)
            {
                int cpuScore = 0;
                int playerScore = 0;
                while (playerScore < 3 && cpuScore < 3)
                {
                    Console.WriteLine("Press any key....");

                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("Choose ROCK, PAPER, or SCISSORS!!!");

                    playerInput = Console.ReadLine();
                    playerInput = playerInput.ToUpper();
                    Random rng = new Random();
                    Random tt = new Random();
                    string[] talk = { "Is that best you got?!", "I can do this in my sleep", "My dog can play better than you!", "Let me know when you want to quit!" };
                    Random bl = new Random();
                    string[] luck = { "That's just beginners luck", "We all get lucky once in awhile", "I know you're cheating!" };

                    randInt = rng.Next(1, 3);

                  
                    if (playerInput == "ROCK" || playerInput == "PAPER" || playerInput == "SCISSORS")
                    {
                        switch (randInt)
                        {
                            case 1:
                                cpuInput = "ROCK";
                                Console.WriteLine("CPU Chose ROCK!");
                                if (playerInput == "ROCK")
                                {
                                    Console.WriteLine("The round was a tie!!!\n");
                                    Console.WriteLine($"Your score: {playerScore}\n");
                                    Console.WriteLine($"CPU score: {cpuScore}\n");
                                }
                                else if (playerInput == "PAPER")
                                {
                                    Console.WriteLine("You won the round!\n");
                                    playerScore = playerScore + 1;

                                    Console.WriteLine(luck[bl.Next(0, luck.Length)], "\n");
                                    Console.WriteLine($"Your score: {playerScore} \n");
                                    Console.WriteLine($"CPU score: {cpuScore}");
                                }
                                else if (playerInput == "SCISSORS")
                                {
                                    Console.WriteLine("The CPU won the round!!!\n");
                                    cpuScore = cpuScore + 1;

                                    Console.WriteLine(talk[tt.Next(0, talk.Length)], "\n");
                                    Console.WriteLine($"Your score: {playerScore} \n");
                                    Console.WriteLine($"CPU score: {cpuScore}");
                                }
                                break;
                            case 2:
                                cpuInput = "PAPER";
                                Console.WriteLine("CPU Chose PAPER!");
                                if (playerInput == "PAPER")
                                {
                                    Console.WriteLine("The round was a tie!!!\n");
                                    Console.WriteLine($"Your score: {playerScore}\n ");
                                    Console.WriteLine($"CPU score: {cpuScore} ");
                                }
                                else if (playerInput == "SCISSORS")
                                {
                                    Console.WriteLine("You won the round!\n");
                                    playerScore = playerScore + 1;

                                    Console.WriteLine(luck[bl.Next(0, luck.Length)], "\n");

                                    Console.WriteLine($"Your score: {playerScore} \n");
                                    Console.WriteLine($"CPU score: {cpuScore} ");
                                }
                                else if (playerInput == "ROCK")
                                {
                                    Console.WriteLine("The CPU won the round!!!\n");
                                    cpuScore = cpuScore + 1;

                                    Console.WriteLine(talk[tt.Next(0, talk.Length)]);
                                    Console.WriteLine($"Your score: {playerScore} \n");
                                    Console.WriteLine($"CPU score: {cpuScore} ");
                                }
                                break;
                            case 3:
                                cpuInput = "SCISSORS";
                                Console.WriteLine("CPU Chose SCISSORS!");
                                if (playerInput == "SCISSORS")
                                {
                                    Console.WriteLine("The round was a tie!!!\n");
                                    Console.WriteLine($"Your score: {playerScore} \n");
                                    Console.WriteLine($"CPU score: {cpuScore} ");
                                }
                                else if (playerInput == "ROCK")
                                {
                                    Console.WriteLine("You won the round!\n");
                                    playerScore = playerScore + 1;

                                    Console.WriteLine(luck[bl.Next(0, luck.Length)], "\n");
                                    Console.WriteLine($"Your score: {playerScore} \n");
                                    Console.WriteLine($"CPU score: {cpuScore} ");
                                }
                                else if (playerInput == "PAPER")
                                {
                                    Console.WriteLine("The CPU won the round!!!\n");
                                    cpuScore = cpuScore + 1;

                                    Console.WriteLine(talk[tt.Next(0, talk.Length)]);
                                    Console.WriteLine($"Your score: {playerScore} \n");
                                    Console.WriteLine($"CPU score: {cpuScore} ");
                                }
                                break;
                            default:
                                Console.WriteLine("Sorry, I don't understand");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Sorry I don't understand....\n");
                    }

                    if (playerScore >= 3 || cpuScore >= 3)
                    {
                        if (playerScore >= 3)
                        {
                            Console.WriteLine("You beat the CPU!!!\n");
                            var myPlayer = new System.Media.SoundPlayer();
                            myPlayer.SoundLocation = @"C:\Users\mdski\OneDrive\Desktop\ElevenFiftyProjects\RockPaperScissors\celebration.wav";
                            myPlayer.PlaySync();
                        }

                        if (cpuScore >= 3)
                        {
                            Console.WriteLine("You lost to the CPU!!!\n");
                            var myPlayer = new System.Media.SoundPlayer();
                            myPlayer.SoundLocation = @"C:\Users\mdski\OneDrive\Desktop\ElevenFiftyProjects\RockPaperScissors\thirsty.wav";
                            myPlayer.PlaySync();

                        }
                        Console.WriteLine("Play Again? (YES/NO)");
                        string repeat = Console.ReadLine();
                        repeat = repeat.ToUpper();
                        if (repeat == "Y")
                        {
                            playAgain = true;
                        }
                        else if (repeat == "N")
                        {
                            playAgain = false;
                        }
                        else
                        {
                        }
                    }

                }
            }
        }
    }
}
