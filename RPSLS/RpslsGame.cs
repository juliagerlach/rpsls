﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class RpslsGame
    {
        //member variables
        public Player player1;
        public Player player2;
        public int player1Score = 0;
        public int player2Score = 0;

        //constructor
        public RpslsGame()
        {

        }

        //member methods
        public void RunGame()
        {
            Console.WriteLine("How many players will be playing? Enter 1 or 2. If 1, an opponent will be assigned.");
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
                Console.WriteLine("Invalid response. Please press any key to continue.");
                Console.ReadLine();
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
                Console.WriteLine("It's a tie! Press any key to continue.");
                Console.ReadLine();
            }
            else if (player1.gesture == 1 && player2.gesture == 2 || player1.gesture == 1 && player2.gesture == 5)
            {
                Console.WriteLine(player2.name + " wins! Press any key to continue.");
                Console.ReadLine();
                player2Score++;
            }

            else if (player1.gesture == 1 && player2.gesture == 3 || player1.gesture == 1 && player2.gesture == 4)
            {
                Console.WriteLine(player1.name + " wins! Press any key to continue.");
                Console.ReadLine();
                player1Score++;
            }

            else if (player1.gesture == 2 && player2.gesture == 3 || player1.gesture == 2 && player2.gesture == 4)
            {
                Console.WriteLine(player2.name + " wins! Press any key to continue.");
                Console.ReadLine();
                player2Score++;
            }

            else if (player1.gesture == 2 && player2.gesture == 1 || player1.gesture == 2 && player2.gesture == 5)
            {
                Console.WriteLine(player1.name + " wins! Press any ky to continue.");
                Console.ReadLine();
                player1Score++;
            }

            else if (player1.gesture == 3 && player2.gesture == 1 || player1.gesture == 3 && player2.gesture == 5)
            {   Console.WriteLine(player2.name + " wins! Press any key to continue.");
                Console.ReadLine();
                player2Score++;
            }

            else if (player1.gesture == 3 && player2.gesture == 2 || player1.gesture == 3 && player2.gesture == 4)
            {
                Console.WriteLine(player1.name + " wins! Press any key to continue.");
                Console.ReadLine();
                player1Score++;
            }

            else if (player1.gesture == 4 && player2.gesture == 1 || player1.gesture == 4 && player2.gesture == 3)
            {
                Console.WriteLine(player2.name + " wins! Press any key to continue.");
                Console.ReadLine();
                player2Score++;
            }

            else if (player1.gesture == 4 && player2.gesture == 2 || player1.gesture == 4 && player2.gesture == 5)
            {
                Console.WriteLine(player1.name + " wins! Press any key to continue.");
                Console.ReadLine();
                player1Score++;
            }

            else if (player1.gesture == 5 && player2.gesture == 2 || player1.gesture == 5 && player2.gesture == 4)
            {
                Console.WriteLine(player2.name + " wins! Press any key to continue.");
                Console.ReadLine();
                player2Score++;
            }

            else if (player1.gesture == 5 && player2.gesture == 1 || player1.gesture == 5 && player2.gesture == 3)
            {
                Console.WriteLine(player1.name + " wins!Press any key to continue.");
                Console.ReadLine();
                player1Score++;
            }
        }
        public void CheckScore()
        {
            if (player1Score <= 2 && player2Score <= 2)
            {
                Console.WriteLine("No one has won the game yet. Press any key to play another round.");
                Console.ReadLine();
            }
            else if (player1Score == 3)
            {
                Console.WriteLine(player1.name + " wins the game! Press any key to start a new game.");
                Console.ReadLine();
            }
            else if (player2Score == 3)
            {
                Console.WriteLine(player2.name + " wins the game! Press any key to start a new game.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Invalid entry. Press any ket to continue.");
            }
        }
    }
}
