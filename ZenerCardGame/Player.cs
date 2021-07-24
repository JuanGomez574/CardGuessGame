using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZenerCardGame
{


    public class PlayerOne
    {
        //properties
        public string name;
        public double percentageScore;
        public static int score;

        //constructors
        public PlayerOne() { }

        public PlayerOne(string Name)
        {
            name = Name;
        }

        //methods we were working with for player scores

        //public double PercentageMaker(int score, int amountOfCards)
        //{


        //double percentage = (Convert.ToDouble(score) / Convert.ToDouble(DeckObject.amountOfCards));
        //return percentage;
        //}
    }


    public class PlayerTwo
    {
        //properties
        public string name;
        //public double percentageScore = PercentageMaker();
        public static int score;

        //constructors
        public PlayerTwo() { }

        public PlayerTwo(string Name)
        {
            name = Name;
        }

        //methods
    }

}