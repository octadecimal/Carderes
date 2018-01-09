using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Carderes.Core.Tests.Evaluators
{
    [TestClass]
    public class CountEvaluatorTests
    {
        [TestMethod]
        public void TestCountEvaluator()
        {
            List<ICard> hand1 = new List<ICard>
            {
                new Card(CardFace.Ace, CardSuit.Club),
                new Card(CardFace.Ace, CardSuit.Diamond),
                new Card(CardFace.Ace, CardSuit.Heart),
                new Card(CardFace.Ace, CardSuit.Spade),
                new Card(CardFace.Five, CardSuit.Club)
            };

            IEvaluator evaluator1 = new CountEvaluator(3);
        }
    }
}
