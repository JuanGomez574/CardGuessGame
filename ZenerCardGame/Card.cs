using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZenerCardGame
{
    public class Card
    {
        public enum SuitType     //creating an enum called SuitType to hold shape values
        {
            Circle = 1,
            Triangle = 2,
            Square = 3,
            Star = 4,

        }
        // property
        public SuitType TypeOfSuit { get; set; }
        // constructors
        public Card() { }
        public Card(SuitType suit)
        {
            TypeOfSuit = suit;
        }
    }
}

