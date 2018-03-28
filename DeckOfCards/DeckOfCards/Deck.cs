﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DeckOfCards
{
    public class Deck<T> : IEnumerable<T>
    {
        int topCard;
        T[] deck = new T[8];

        public void Add(T card)
        {
            if (deck.Length == topCard)
            {
                Array.Resize(ref deck, deck.Length * 2);
            }
            deck[topCard++] = card;
        }

        public T DealOne()
        {
            if (deck.Length < topCard / 3)
            {
                Array.Resize(ref deck, deck.Length / 2);
            }
            return deck[topCard--];
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < topCard; i++)
            {
                yield return deck[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}