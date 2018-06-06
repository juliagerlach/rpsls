using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Computer : Player
    {
        public override void GetPlayerName()
        {
            name = "Carnak";
            Console.WriteLine($"{name} the computer is your opponent. Press 'enter' to continue");
            Console.ReadLine();
        }

        public override int ChooseGesture()
        {
            Random random = new Random();
            gesture = random.Next(1,5);
            return gesture;
        }
    }
}
