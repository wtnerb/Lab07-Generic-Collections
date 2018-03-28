using System;
using Xunit;
using DeckOfCards;

namespace TestDeckAndCards
{
    public class UnitTest1
    {
        [Fact]
        //[InlineData(new Card(V.Ten, S.Hearts),  4)]
        //[InlineData(new Card(V.Queen, S.Clubs), 2)]
        //[InlineData(new Card(V.Ace, S.Spades), 0)]
        public void CanBuildDeck()
        {
            Deck<Card> test = new Deck<Card> {
                new Card (V.Ace, S.Spades),
                new Card(V.King, S.Hearts),
                new Card(V.Queen, S.Clubs),
                new Card(V.Jack, S.Diamonds),
                new Card(V.Ten, S.Hearts),
            };
            Assert.Equal(new Card(V.Ten, S.Hearts), test.AtIndex(4));
        }

        [Fact]
        public void CanCreateCard()
        {
            Card ace = new Card(V.Ace, S.Spades);
            Assert.Equal(new int[] { ace.Value, ace.Suit }, new int[] { 14, 2 });
        }
    }
}
