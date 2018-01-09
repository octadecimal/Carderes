using System;
using System.Collections.Generic;
using System.Text;

namespace Carderes.Core
{
    public class Card : ICard
    {
        public CardFace Face { get; }
        public CardSuit Suit { get; }

        public Card(CardFace face, CardSuit suit)
        {
            Face = face;
            Suit = suit;
        }
    }
}
