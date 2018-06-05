using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Program
    {
        static void Main(string[] args)
        {
            RpslsGame myRpslsGame = new RpslsGame();
            myRpslsGame.SetPlayers();
            myRpslsGame.ChooseGesture();
            myRpslsGame.CompareGestures();
            

            //myRpslsGame.player1.InterpretGestures();
            //myRpslsGame.player2.InterpretGestures();

        }
    }
}
