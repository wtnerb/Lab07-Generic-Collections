using System;
using System.Collections.Generic;
using System.Text;

namespace DeckOfCards
{
    public class Card
    {
        public S Suit { get; set; }
        public V Value { get; set; }

        public Card(V value, S suit)
        {
            Suit = suit;
            Value = value;
        }

        public bool IsSame (Card c)
        {
            return Suit == c.Suit && Value == c.Value;
        }
    }
}
