using System;
using System.Collections.Generic;
using System.Text;

namespace DeckOfCards
{
    public class Card
    {
        public Card(Suit s, Value v)
        {
            
        }


        public enum Suit : byte
        {
            Heart,
            Spade,
            Diamond,
            Club
        }

        public enum Value : byte
        {
            two = 2,
            three,
            four,
            five,
            six,
            seven,
            eight,
            nine,
            ten,
            jack,
            queen,
            king,
            ace
        }
    }
}
