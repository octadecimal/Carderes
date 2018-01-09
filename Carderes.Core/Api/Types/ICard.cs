using System;
using System.Collections.Generic;
using System.Text;

namespace Carderes.Core
{
    public interface ICard
    {
        CardFace Face { get; }
        CardSuit Suit { get; }
    }
}
