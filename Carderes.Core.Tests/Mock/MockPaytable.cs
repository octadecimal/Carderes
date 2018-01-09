using System;
using System.Collections.Generic;

namespace Carderes.Core.Tests.Mock
{
    public class MockPaytable : Paytable
    {
        public MockPaytable()
        {
            // Setup card hierarchy
            List<CardFace> hierarchies = new List<CardFace>
            {
                CardFace.Ace,
                CardFace.King,
                CardFace.Queen,
                CardFace.Jack,
                CardFace.Ten,
                CardFace.Nine,
                CardFace.Eight,
                CardFace.Seven,
                CardFace.Six,
                CardFace.Five,
                CardFace.Four,
                CardFace.Three,
                CardFace.Two
            };

            // Set card hierarchy
            SetCardHierarchy(hierarchies);
        }
    }
}
