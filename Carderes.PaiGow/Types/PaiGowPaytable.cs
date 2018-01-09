using Carderes.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Carderes.PaiGow.Types
{
    public class PaiGowPaytable : Paytable
    {
        public PaiGowPaytable()
        {
            // Setup card hierarchy
            List<CardFace> cardHierarchy = new List<CardFace>
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

            SetCardHierarchy(cardHierarchy);

            // Setup scenarios
            AddScenario("4 of a kind", new int[] { 25, 50, 75, 100, 125 }, new CountEvaluator(4));
            AddScenario("3 of a kind", new int[] { 25, 50, 75, 100, 125 }, new CountEvaluator(3));
        }
    }
}
