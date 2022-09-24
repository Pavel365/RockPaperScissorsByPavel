using System;

namespace RockPaperScissors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string Rock = "Rock";
            const string Paper = "Paper";
            const string Scissors = "Scissors";

            Console.Write("Choose [r]ock, [p]aper or [s]cissors: ");
            string playerMove = Console.ReadLine();

            if (playerMove == "r" || playerMove == "rock")
            {
                playerMove = Rock;
            }
            else if (playerMove == "p" || playerMove == "paper")
            {
                playerMove = Paper;
            }
            else if (playerMove == "s" || playerMove == "scissors")
            {
                playerMove = Scissors;
            }
            else
            {
                Console.WriteLine("Invalid Input. Try Again ...");
                return;
            }

            Random random = new Random();
            int computerRandomNumber = random.Next(1,4);

            string computerMove = "";

            switch (computerRandomNumber)
            {
                case 1:computerMove = Rock;
                    break;
                case 2:computerMove = Paper;
                    break;
                case 3:computerMove = Scissors;
                    break;
            }
            Console.WriteLine($"The computer chose {computerMove}.");

            if ((playerMove == Rock && computerMove == Scissors) ||
                (playerMove == Paper && computerMove == Rock) ||
                (playerMove == Scissors && computerMove == Paper))
            {
                Console.WriteLine("You win.");
            }
            else if ((playerMove == Rock && computerMove == Paper) ||
                     (playerMove == Paper && computerMove == Scissors) ||
                     (playerMove == Scissors && computerMove == Rock))
            {
                Console.WriteLine("You lose.");
            }
            else
            {
                Console.WriteLine("This game was a draw.");
            }

            Console.Write("Type [yes] to Play Again or [no] to quit: ");
            string playerChoose = Console.ReadLine();

            if (playerChoose == "yes")
            {
                Console.Write("Choose [r]ock, [p]aper or [s]cissors: ");

                string playerMove1 = Console.ReadLine();

                if (playerMove1 == "r" || playerMove1 == "rock")
                {
                    playerMove1 = Rock;
                }
                else if (playerMove1 == "p" || playerMove1 == "paper")
                {
                    playerMove1 = Paper;
                }
                else if (playerMove1 == "s" || playerMove1 == "scissors")
                {
                    playerMove1 = Scissors;
                }
                else
                {
                    Console.WriteLine("Invalid Input. Try Again ...");
                    return;
                }

                Random random1 = new Random();
                int computerRandomNumber1 = random1.Next(1, 4);

                string computerMove1 = "";

                switch (computerRandomNumber1)
                {
                    case 1:
                        computerMove1 = Rock;
                        break;
                    case 2:
                        computerMove1 = Paper;
                        break;
                    case 3:
                        computerMove1 = Scissors;
                        break;
                }
                Console.WriteLine($"The computer chose {computerMove1}.");

                if ((playerMove1 == Rock && computerMove1 == Scissors) ||
                    (playerMove1 == Paper && computerMove1 == Rock) ||
                    (playerMove1 == Scissors && computerMove1 == Paper))
                {
                    Console.WriteLine("You win.");
                }
                else if ((playerMove1 == Rock && computerMove1 == Paper) ||
                         (playerMove1 == Paper && computerMove1 == Scissors) ||
                         (playerMove1 == Scissors && computerMove1 == Rock))
                {
                    Console.WriteLine("You lose.");
                }
                else
                {
                    Console.WriteLine("This game was a draw.");
                }
            }
            else if (playerChoose == "no")
            {
                Console.WriteLine("Thank you for playing.");
            }
            else
            {
                Console.WriteLine("Invalid Input.");
            }
        }
    }
}
