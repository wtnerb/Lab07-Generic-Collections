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

        [Fact]
        public void CanCreateCard()
        {
            Card ace = new Card(V.Ace, S.Spades);
            Assert.Equal(new int[] { ace.Value, ace.Suit }, new int[] { 14, 2 });
        }
    }
}
