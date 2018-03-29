using System;

namespace DeckOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Deck<Card> royals = new Deck<Card> {
                new Card (V.Ace, S.Spades),
                new Card(V.King, S.Spades),
                new Card(V.Queen, S.Spades),
                new Card(V.Jack, S.Spades),
                new Card(V.Ten, S.Spades),
                new Card (V.Ace, S.Diamonds),
                new Card(V.King, S.Diamonds),
                new Card(V.Queen, S.Diamonds),
                new Card(V.Jack, S.Diamonds),
                new Card(V.Ten, S.Diamonds),
                new Card (V.Ace, S.Hearts),
                new Card(V.King, S.Hearts),
                new Card(V.Queen, S.Hearts),
                new Card(V.Jack, S.Hearts),
                new Card(V.Ten, S.Hearts),
                new Card (V.Ace, S.Clubs),
                new Card(V.King, S.Clubs),
                new Card(V.Queen, S.Clubs),
                new Card(V.Jack, S.Clubs),
                new Card(V.Ten, S.Clubs),
            };
            foreach (Card c in royals)
            {
                Console.WriteLine($"{(V)c.Value} {(S)c.Suit}");
            }
        }
    }
}
