using System;
using System.Collections.Generic;
using System.Text;

namespace DeckOfCards
{
    class Enums
    {
    }
        public enum Suit : byte
        {
            Hearts = 1,
            Spades,
            Diamonds,
            Clubs
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
