using System;
using System.Collections.Generic;
using System.Text;

namespace DeckOfCards
{
    public class Card
    {
        public int Suit { get; set; }
        public int Value { get; set; }

        public Card(byte suit, byte value)
        {
            Suit = suit;
            Value = value;
        }


        //public enum Suit : byte
        //{
        //    Heart,
        //    Spade,
        //    Diamond,
        //    Club
        //}

        //public enum Value : byte
        //{
        //    two = 2,
        //    three,
        //    four,
        //    five,
        //    six,
        //    seven,
        //    eight,
        //    nine,
        //    ten,
        //    jack,
        //    queen,
        //    king,
        //    ace
        //}
    }
}
