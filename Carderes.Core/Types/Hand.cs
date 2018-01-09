using System;
using System.Collections.Generic;
using System.Text;

namespace Carderes.Core
{
    public class Hand : IHand
    {
        public ICard[] Cards { get; }

        public Hand(int size)
        {
            Cards = new ICard[size];
        }

        public int Count { get { return Cards.Length; } }

        public void AddCardAt(ICard card, int index)
        {
            Cards[index] = card;
        }

        public void RemoveCardAt(int index)
        {
            Cards[index] = null;
        }

        public int CountOf(CardFace face)
        {
            int numFound = 0;

            foreach (ICard card in Cards)
            {
                if (card.Face == face)
                {
                    numFound++;
                }
            }

            return numFound;
        }

        public bool ContainsExactly(CardFace face, int count)
        {
            return CountOf(face) == count;
        }

        public bool ContainsAtLeast(CardFace face, int count)
        {
            return CountOf(face) >= count;
        }
    }
}
