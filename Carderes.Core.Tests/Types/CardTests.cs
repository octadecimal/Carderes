using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Carderes.Core.Tests.Types
{
    [TestClass]
    public class CardTests
    {
        [TestMethod]
        public void TestCardFaceAndSuitAssignment()
        {
            ICard card = new Card(CardFace.Ace, CardSuit.Club);
            Assert.AreEqual(card.Face, CardFace.Ace);
            Assert.AreEqual(card.Suit, CardSuit.Club);
        }
    }
}
