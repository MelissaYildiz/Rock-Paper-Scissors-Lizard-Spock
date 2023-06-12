using System.IO.Pipes;

namespace Rock_Paper_Scissors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            bool playAgain = true;
            string player;
            string computer;
            string answer;

            while (playAgain)
            {
                player = "";
                computer = "";
                answer = "";

                while(player != "ROCK" && player != "PAPER" && player != "SCISSORS" && player != "LIZARD" && player != "SPOCK")
                {
                    Console.WriteLine("ROCK, PAPER, SCISSORS, LIZARD OR SPOCK?");
                    player = Console.ReadLine();
                    player = player.ToUpper();
                }

                switch (random.Next(1, 6))
                {
                    case 1:
                       computer = "ROCK";
                       break;

                    case 2: 
                       computer = "PAPER";
                       break;

                    case 3:
                        computer = "SCISSORS";
                        break;

                    case 4:
                        computer = "LIZARD";
                        break;

                    case 5:
                        computer = "SPOCK";
                        break;
                }
                Console.WriteLine("Player: " + player);
                Console.WriteLine("Computer: " + computer);

                switch (player)
                {
                    case "ROCK":
                        if(computer == "SCISSORS")
                        {
                            Console.WriteLine("You won THE GAME!!!");
                        }
                        else if(computer == "PAPER")
                        { 
                            Console.WriteLine("You lost THE GAME!!!");
                        }
                        else if(computer == "LIZARD")
                        {
                            Console.WriteLine("You won THE GAME!!!");
                        }
                        else if(computer == "SPOCK")
                        {
                            Console.WriteLine("You lost THE GAME!!!");
                        }
                        else
                        { 
                            Console.WriteLine("Draw! TRY AGAIN"); 
                        }
                        break;


                    case "PAPER":
                        if (computer == "ROCK")
                        {
                            Console.WriteLine("You won THE GAME!!!)");
                        }
                        else if (computer == "SCISSORS")
                        {
                            Console.WriteLine("You lost THE GAME!!!");
                        }
                        else if (computer == "LIZARD")
                        {
                            Console.WriteLine("You lost THE GAME!!!");
                        }
                        else if (computer == "SPOCK")
                        {
                            Console.WriteLine("You won THE GAME!!!");
                        }
                        else
                        {
                            Console.WriteLine("DRAW!TRY AGAIN");
                        }
                        break;

                    case "SCISSORS":
                        if (computer == "ROCK")
                        {
                            Console.WriteLine("You lost THE GAME!!!)");
                        }
                        else if (computer == "PAPER")
                        {
                            Console.WriteLine("You won THE GAME!!!");
                        }
                        else if (computer == "LIZARD")
                        {
                            Console.WriteLine("You won THE GAME!!!");
                        }
                        else if (computer == "SPOCK")
                        {
                            Console.WriteLine("You lost THE GAME!!!");
                        }
                        else
                        {
                            Console.WriteLine("DRAW! TRY AGAIN");
                        }
                        break;

                    case "LIZARD":
                        if (computer == "ROCK")
                        {
                            Console.WriteLine("You lost THE GAME!!!");
                        }
                        else if (computer == "PAPER")
                        {
                            Console.WriteLine("You won THE GAME!!!");
                        }
                        else if (computer == "SCISSORS")
                        {
                            Console.WriteLine("You lost THE GAME!!!");
                        }
                        else if (computer == "SPOCK")
                        {
                            Console.WriteLine("You won THE GAME!!!");
                        }
                        else
                        {
                            Console.WriteLine("DRAW! TRY AGAIN");
                        }
                        break;

                    case "SPOCK":
                        if (computer == "ROCK")
                        {
                            Console.WriteLine("You won THE GAME!!!)");
                        }
                        else if (computer == "PAPER")
                        {
                            Console.WriteLine("You lost THE GAME!!!");
                        }
                        else if (computer == "LIZARD")
                        {
                            Console.WriteLine("You lost THE GAME!!!");
                        }
                        else if (computer == "SCISSORS")
                        {
                            Console.WriteLine("You won THE GAME!!!");
                        }
                        else
                        {
                            Console.WriteLine("DRAW! TRY AGAIN");
                        }
                        break;

                }
                Console.WriteLine("Play Again? (Y/N) ");
                answer = Console.ReadLine();
                answer = answer.ToUpper();

                if(answer == "Y")
                {
                    playAgain = true;
                }
                else 
                {
                    playAgain = false;
                }

            }

            Console.WriteLine(" OK BYE... ");

            Console.ReadKey();
        }
    }
}