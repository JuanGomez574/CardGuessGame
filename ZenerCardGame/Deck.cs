using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZenerCardGame
{
    public class DeckOfCards : Card   //card is the base class of "DeckOfCards"
    {   //properties
        public int NumOfCards { get; set; }
        public Card[] Deck { get; set; }


        //constructors
        public DeckOfCards() { }
        public DeckOfCards(int numOfCards, Card[] deck)  //passing in arguments of number of cards, and empty deck
        {
            NumOfCards = numOfCards;
            Deck = deck;
        }


        public Card[] DeckRandomizor(int numOfCards)  //pass in number of cards for randomizor
        {

            Random rnd = new Random();       //instantiates a random object
            for (int i = 0; i < numOfCards; i++)
            {
                //below, for each deck index, we create a type of suit based on random values
                //(from 1 to 4) that each shape is equal to
                Deck[i] = new Card { TypeOfSuit = (SuitType)rnd.Next(1, 4) };
            }
            return Deck;
        }

        //Below when uncommented, is where we attempted to output the int value of each card to later
        //compare with the guessed value of each shape


        //public SuitType ShapeCreater(int NumOfCards, Card[] deck)
        //{
        // for (int j = 0; j < NumOfCards; j++)
        // {
        // if (Deck[j] = SuitType.Circle)  //if the current is equal to the Circle SuitType (1) then return value
        // {
        // return SuitType.Circle;
        // }
        // else if (Deck[j] = SuitType.Triangle)  //if the current is equal to the Triangle SuitType (2) then return value
        // {
        // return SuitType.Triangle;
        // }
        // else if (Deck[j] = SuitType.Square)  //if the current is equal to the Square SuitType (3) then return value
        // {
        // return SuitType.Square;
        // }
        // else
        // {
        // return SuitType.Star; //if the current is equal to the Star SuitType (4) then return value
        // }
        // }



    }
}
