using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class RpslsGame
    {
        public Player player1;
        public Player player2;
        public int player1Score = 0;
        public int player2Score = 0;

        public RpslsGame()
        {

        }

        public void Introduction()
        {
            Console.WriteLine("Welcome to Rock, Paper, Scissors, Lizard, Spock. At the beginning of each round, you will be prompted to choose between the five options: rock, paper, scissors, lizard, or Spock. \n\nThe winner is determined as follows: \nScissors cuts paper. \nPaper covers rock. \nRock crushes lizard.\nLizard poisons Spock. \nSpock smashes scissors. \nScissors decapitates lizard. \nLizard eats paper. \nPaper disproves Spock. \nSpock vaporizes rock. \nRock crushes scissors. \n\nThe winner of each round will be displayed. The first person to win three rounds wins the game. \nPress 'enter' to play.");
            Console.ReadLine();
        }
        public void RunGame()
        {
            Console.WriteLine("How many players will be playing? \nEnter 1 or 2 to make your choice. If 1, an opponent will be assigned.");
            string numberOfPlayers = Console.ReadLine();
            if (numberOfPlayers == "1")
            {
                player1 = new Human();
                player1.GetPlayerName();

                player2 = new Computer();
                player2.GetPlayerName();
            }
            else if (numberOfPlayers == "2")
            {
                player1 = new Human();
                player1.GetPlayerName();

                player2 = new Human();
                player2.GetPlayerName();
            }
            else
            {
                Console.WriteLine("Invalid response. Please press 'enter' to continue.");
                Console.ReadLine();
                RunGame();
            }
        }
        public void GetPlayerName()
        {

        }
        public void PlayRounds()
        {
            while (player1Score <= 2 && player2Score <= 2)
            {
                ChooseGesture();
                CompareGestures();
                CheckScore();
            }
        }
        
    public void ChooseGesture()
        {
            player1.gesture = player1.ChooseGesture();
            player2.gesture = player2.ChooseGesture();
        }

        public void CompareGestures()
        {
            if (player1.gesture == player2.gesture)
            {
                Console.WriteLine("It's a tie! Press 'enter' to continue.");
                Console.ReadLine();
            }
            else if (player1.gesture == 1 && player2.gesture == 2 || player1.gesture == 1 && player2.gesture == 5)
            {
                Console.WriteLine(player2.name + " wins! Press 'enter' to continue.");
                Console.ReadLine();
                player2Score++;
            }

            else if (player1.gesture == 1 && player2.gesture == 3 || player1.gesture == 1 && player2.gesture == 4)
            {
                Console.WriteLine(player1.name + " wins! Press 'enter' to continue.");
                Console.ReadLine();
                player1Score++;
            }

            else if (player1.gesture == 2 && player2.gesture == 3 || player1.gesture == 2 && player2.gesture == 4)
            {
                Console.WriteLine(player2.name + " wins! Press 'enter' to continue.");
                Console.ReadLine();
                player2Score++;
            }

            else if (player1.gesture == 2 && player2.gesture == 1 || player1.gesture == 2 && player2.gesture == 5)
            {
                Console.WriteLine(player1.name + " wins! Press 'enter' to continue.");
                Console.ReadLine();
                player1Score++;
            }

            else if (player1.gesture == 3 && player2.gesture == 1 || player1.gesture == 3 && player2.gesture == 5)
            {   Console.WriteLine(player2.name + " wins! Press 'enter' to continue.");
                Console.ReadLine();
                player2Score++;
            }

            else if (player1.gesture == 3 && player2.gesture == 2 || player1.gesture == 3 && player2.gesture == 4)
            {
                Console.WriteLine(player1.name + " wins! Press 'enter' to continue.");
                Console.ReadLine();
                player1Score++;
            }

            else if (player1.gesture == 4 && player2.gesture == 1 || player1.gesture == 4 && player2.gesture == 3)
            {
                Console.WriteLine(player2.name + " wins! Press 'enter' to continue.");
                Console.ReadLine();
                player2Score++;
            }

            else if (player1.gesture == 4 && player2.gesture == 2 || player1.gesture == 4 && player2.gesture == 5)
            {
                Console.WriteLine(player1.name + " wins! Press 'enter' to continue.");
                Console.ReadLine();
                player1Score++;
            }

            else if (player1.gesture == 5 && player2.gesture == 2 || player1.gesture == 5 && player2.gesture == 4)
            {
                Console.WriteLine(player2.name + " wins! Press any 'enter' to continue.");
                Console.ReadLine();
                player2Score++;
            }

            else if (player1.gesture == 5 && player2.gesture == 1 || player1.gesture == 5 && player2.gesture == 3)
            {
                Console.WriteLine(player1.name + " wins! Press 'enter' to continue.");
                Console.ReadLine();
                player1Score++;
            }
        }
        public void CheckScore()
        {
            if (player1Score <= 2 && player2Score <= 2)
            {
                Console.WriteLine("No one has won the game yet. Press 'enter' to play another round.");
                Console.ReadLine();
            }
            else if (player1Score == 3)
            {
                Console.WriteLine(player1.name + " wins the game! Press 'enter' to start a new game.");
                Console.ReadLine();
                RunGame();
            }
            else if (player2Score == 3)
            {
                Console.WriteLine(player2.name + " wins the game! Press 'enter' to start a new game.");
                Console.ReadLine();
                RunGame();
            }
            else
            {
                Console.WriteLine("Invalid entry. Type 'play' to continue or 'quit' to exit.");
                string response = Console.ReadLine();
                if (response == "play")
                {
                    PlayRounds();
                }
                if (response == "quit")
                {
                    Console.WriteLine("Thanks for playing Rock, Paper, Scissors, Lizard, Spock! Come back and play again soon.");
                    Console.ReadLine();
                }
            }
        }
    }
}
