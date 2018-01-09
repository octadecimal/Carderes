using System;
using System.Collections.Generic;
using Carderes.Core.Tests.Mock;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Carderes.Core.Tests.Evaluators
{
    [TestClass]
    public class CountEvaluatorTests
    {
        [TestMethod]
        public void TestCountEvaluator()
        {
            IPaytable paytable = new MockPaytable();

            IHand hand = new Hand(5);
            hand.AddCardAt(new Card(CardFace.Ace, CardSuit.Club), 0);
            hand.AddCardAt(new Card(CardFace.Ace, CardSuit.Heart), 1);
            hand.AddCardAt(new Card(CardFace.Ace, CardSuit.Spade), 2);
            hand.AddCardAt(new Card(CardFace.Five, CardSuit.Diamond), 3);
            hand.AddCardAt(new Card(CardFace.Five, CardSuit.Club), 4);

            // 3 of a kind (should pass)
            IEvaluator evaluator1 = new CountEvaluator(3);
            IHandResult result1 = evaluator1.Evaluate(hand, paytable);

            // 4 of a kind (should fail)
            IEvaluator evaluator2 = new CountEvaluator(4);
            IHandResult result2 = evaluator2.Evaluate(hand, paytable);

            Assert.IsTrue(result1.Matched);
            Assert.IsFalse(result2.Matched);
        }
    }
}
