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
            myRpslsGame.Introduction();
            myRpslsGame.RunGame();
            myRpslsGame.PlayRounds();
        }
    }
}
