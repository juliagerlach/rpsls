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
            myRpslsGame.RunGame();
            myRpslsGame.PlayRounds();

            //myRpslsGame.player1.InterpretGestures();
            //myRpslsGame.player2.InterpretGestures();

        }
    }
}
