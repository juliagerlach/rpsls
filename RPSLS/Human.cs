using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Human:Player
    {
        
        public Human ()
        {
            name = "";
        }
        public override void GetPlayerName()
        {
            
            Console.WriteLine("Please enter your name and then press 'enter.'");
            name = Console.ReadLine();
            
        }

        public override int ChooseGesture()
        {

            Console.WriteLine(name + ", please enter your selected gesture: Type 1 for 'rock', 2 for 'paper', 3 for 'scissors', 4 for 'lizard', or 5 for 'Spock.', and then press enter");
            gesture = Convert.ToInt32(Console.ReadLine());

            return gesture;
        }
    }
}
