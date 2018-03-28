using System;
using System.Collections.Generic;
using System.Text;

namespace DeckOfCards
{
    public class Card
    {
        public int Suit { get; set; }
        public int Value { get; set; }

        public Card(V value, S suit)
        {
            Suit = (byte)suit;
            Value = (byte)value;
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
