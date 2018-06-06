using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public abstract class Player
    {
        public string name;
        public int gesture;
        string[] gestureArray = new string[2];
        public List<string> gestureOptions = new List<string>() { "rock", "paper", "scissors", "lizard", "Spock" };

        public virtual void GetPlayerName()
        {

        }
        public abstract int ChooseGesture();        
    }
}
