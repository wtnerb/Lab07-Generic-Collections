using System;
using Xunit;
using DeckOfCards;

namespace TestDeckAndCards
{
    public class UnitTest1
    {
        //[Fact]
        //public void CanBuildDeck()
        //{
        //    Deck<Card> test = new Deck<Card>();
        //}

        public void CanCreateCard()
        {
            Card ace = Card("ace", "spades");
        }
    }
}
