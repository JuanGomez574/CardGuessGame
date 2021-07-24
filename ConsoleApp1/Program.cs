using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//We had the idea mapped out, however we were unable to complete it in time due to the very last logic we were working on
//We basically wanted to be able to solve it ourselves as a team and not ask for help
//We learned alot by discovering solutions using the resources available as we went and are open
//and welcome to any possible feedback about where our last commented-out method in the deck class was not working

namespace Console_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            UI game = new UI();  //instantiates the UI
            game.Run();   //method to start game
        }

    }
}