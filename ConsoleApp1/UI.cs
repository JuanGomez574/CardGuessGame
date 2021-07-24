using System;
using ZenerCardGame;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Game described below

//This console game is a two player card game with a user-defined number of cards,
//Each card has one of four shapes: a circle, triangle, square, or a star
//One by one each player guesses what the next card will be
//Player scores are compared to determine winner

namespace Console_Game
{
    class UI
    {
        //instantiated the two players
        public PlayerOne Player1 = new PlayerOne();
        public PlayerTwo Player2 = new PlayerTwo();



        //UI Run Method for the program UI.Run()
        public void Run()
        {
            RunGame();
        }

        //Menu Method
        public void RunGame()
        {
            //Homescreen
            bool keepGoing = true;
            while (keepGoing)
            {
                Console.Clear();
                Console.WriteLine("Welcome. What would you like to do?\n" +
                    "1. Play a Zener Card Game.\n" +
                    "2. Exit.\n");

                //Recieves user menu choice
                string userInput = Console.ReadLine();

                Console.Clear();  //Keeping the console clean
                switch (userInput)
                {
                    case "1":
                        //running game
                        Game();
                        break;
                    case "2":
                        //exits program
                        Console.WriteLine("Press any key to exit ...");
                        Console.ReadKey();
                        keepGoing = false;
                        break;
                    default:
                        Console.WriteLine("You did not select a valid option. Please select an option by using the number of the option.");
                        break;
                }
            }
        }


        public void Game()  //game method that runs when game starts
        {
            bool playingGame = true;
            while (playingGame)
            {
                Console.Clear();
                Console.WriteLine("Hello and welcome to the game \n" +
                        "Please enter name of Player One");

                //player one's name
                string playerOneName = Console.ReadLine();

                Console.Clear();

                Player1.name = playerOneName;   //user input is used as player two's name

                Console.WriteLine("Great! Now please enter name of Player Two.");

                //player two's name
                string playerTwoName = Console.ReadLine();

                Player2.name = playerTwoName;  //user input is used as player two's name

                Console.WriteLine("How many cards will we have in our deck today");

                int numberChoice = int.Parse(Console.ReadLine());  //converts user input to int

                //instantiated a new DeckOfCards object
                DeckOfCards newDeck = new DeckOfCards();

                //we used user's input to determine number of cards in deck
                newDeck.DeckRandomizor(numberChoice);


            }
        }
    }
}
