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

        public bool IsSame (Card c)
        {
            return Suit == c.Suit && Value == c.Value;
        }
    }
}
