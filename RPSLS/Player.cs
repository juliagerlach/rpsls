using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public abstract class Player
    {
        //member variables
        public string name;
        public int gesture;
        string[] gestureArray = new string[2];
        public List<string> gestureOptions = new List<string>() { "rock", "paper", "scissors", "lizard", "Spock" };

        //member methods
        public virtual void GetPlayerName()
        {

        }
        public abstract int ChooseGesture();        
        //public void InterpretGestures()
        //{
            //foreach (string gesture in gestureArray)
            //{
                //string gestureName = gestureOptions[gesture];
                //for (int i = 0; i < gestureOptions.Count; i++) ;
                //if (true)
                //{
                //    Console.WriteLine(gesture);
                //    Console.ReadLine();
                //}
            //}
        //}
    }
}
