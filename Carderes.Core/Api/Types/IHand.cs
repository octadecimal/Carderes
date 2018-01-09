using System;
using System.Collections.Generic;
using System.Text;

namespace Carderes.Core
{
    public interface IHand
    {
        ICard[] Cards { get; }
        int Count { get; }

        void AddCardAt(ICard card, int index);
        void RemoveCardAt(int index);
        int CountOf(CardFace face);
        bool ContainsExactly(CardFace face, int count);
        bool ContainsAtLeast(CardFace face, int count);
    }
}
