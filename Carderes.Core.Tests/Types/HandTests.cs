using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Carderes.Core.Tests.Types
{
    [TestClass]
    public class HandTests
    {
        [TestMethod]
        public void TestAddRemoveCards()
        {
            IHand hand = new Hand(5);
            Assert.AreEqual(hand.Count, 5);

            hand.AddCardAt(new Card(CardFace.King, CardSuit.Club), 0);
            Assert.AreEqual(hand.Cards[0].Face, CardFace.King);
            Assert.AreEqual(hand.Cards[0].Suit, CardSuit.Club);

            hand.AddCardAt(new Card(CardFace.Queen, CardSuit.Diamond), 1);
            Assert.AreEqual(hand.Cards[0].Face, CardFace.King);
            Assert.AreEqual(hand.Cards[0].Suit, CardSuit.Club);
            Assert.AreEqual(hand.Cards[1].Face, CardFace.Queen);
            Assert.AreEqual(hand.Cards[1].Suit, CardSuit.Diamond);
            Assert.IsNull(hand.Cards[2]);
            Assert.IsNull(hand.Cards[3]);
            Assert.IsNull(hand.Cards[4]);
        }
    }
}
