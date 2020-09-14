using System;

namespace JanKenPon
{
    class RockPaperScissors
    {
        static void Main(string[] args)
        {
            RPSGame();
            Console.ReadLine();
        }

        private static void RPSGame()
        {
            Random rnd = new Random();
            int comp = rnd.Next(1, 4);

            //variables to track score of the game
            int playerWins = 0;
            int compWins = 0;
            int drawCount = 0;
            bool playAgain = true;                   
            while (playAgain)
            {
                try
                {
                    Console.WriteLine("Rock Paper Scissors game");
                    Console.WriteLine("1 for Rock 2 for Paper or 3 for Scissors or 0 to exit");
                    int player = Convert.ToInt32(Console.ReadLine());

                    if (player == comp)
                    {
                        Console.WriteLine("It's a tie");
                        drawCount++;
                    }
                    else if (player == 1 && comp == 2)
                    {
                        Console.WriteLine("Computer chose paper, you lose!");
                        compWins++;
                    }
                    else if (player == 1 && comp == 3)
                    {
                        Console.WriteLine("Rock breaks scissors, you win!");
                        playerWins++;
                    }
                    else if (player == 2 && comp == 3)
                    {
                        Console.WriteLine("Computer chose scissors, you lose!");
                        compWins++;
                    }
                    else if (player == 2 && comp == 1)
                    {
                        Console.WriteLine("Paper covers rock, you win!");
                        playerWins++;
                    }
                    else if (player == 3 && comp == 1)
                    {
                        Console.WriteLine("Computer chose rock, you lose!");
                        compWins++;
                    }
                    else if (player == 3 && comp == 2)
                    {
                        Console.WriteLine("Scissors cut paper, you win! ");
                        playerWins++;
                    }
                    else if (player == 0)
                    {
                        Console.WriteLine("Exiting now...");
                        Environment.Exit(0);
                    }
                    else
                    {
                        Console.WriteLine("Number not within specified range 1-3");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Input must be a numeric integer value");
                }
                Console.WriteLine("Win count: " + playerWins);
                Console.WriteLine("Lose count: " + compWins);
                Console.WriteLine("Draw count: " + drawCount);
            } 
        }
    }
}
