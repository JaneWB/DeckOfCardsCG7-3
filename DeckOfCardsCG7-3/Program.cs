using System;

namespace DeckOfCardsCG7_3
{
    //Create a program that contains a deck of cards and randomly draws one.
    //You will need a Card class to store information about each individual 
    //card.The Card class should have a method that gives you the full card 
    //name like “2 of Hearts”. You will need a Deck class that contains an 
    //array of all the cards.The Deck class will need a method to draw a 
    //random card.Your main method in the Program class should create a deck 
    //object, draw a random card and display the value.

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Random card drawn is:");
            Deck deck = new Deck(); //create variable, set to new variable using Class Constructor method.The () means using method.
            Card drawnCard = deck.RandomDraw();//create variable using Class, set to RandomDraw method from deck.
            Console.WriteLine(drawnCard.NameOfCard());//Printing to Console the name of the card from the Class.
            Console.ReadLine();
        }
    }

    public class Card
    {


        public string Suit { get; set; }//property and a method combined
        public string Value { get; set; }//property and a method combined

        public Card(string suit, string value)//constructor puts the suit and the value into the Card so it is not null.
        {

            Suit = suit;
            Value = value;
        }
        //who can use it, return type (string), method name, () are the params. 
        public string NameOfCard()//outputs the name of the card. This is a method because it has (). If void do not need return.  This will return a string cause it is called string.
        {
            return Value + " of " + Suit;
        }


        /*private string suit;

        public string getSuit()
        {
            return suit;
        }
        public void setSuit(string suit)
        {
            this.suit = suit;

        }
        */

    }

    public class Deck
    {
        public Card[] cards;// = new Card[52];//creates variable for an array using the Card class as the template of an array

        public Deck()//constructor which is a specailized method
        {
            cards = new Card[52];//creates array of 52 that holds a type of Card (the Card Class).
            string[] values = { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" }; //creates array
            string[] suits = { "Clubs", "Diamonds", "Hearts", "Spades" };//creates array

            for (int i = 0; i < suits.Length; i++)//loops through the suits array
            {
                for (int j = 0; j < values.Length; j++)//loop inside a loop and goes through all the values
                {
                    cards[i * values.Length + j] = new Card(suits[i], values[j]);//puts values in the array (cards
                }
            }
        }

        public Card RandomDraw()//method
        {
            Random r = new Random();
            return cards[r.Next(52)];
        }


    }

}
