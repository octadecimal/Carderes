using Microsoft.VisualStudio.TestTools.UnitTesting;
using Carderes.Core.Tests.Mock;

namespace Carderes.Core.Tests.Types
{
    [TestClass]
    public class PaytableTests
    {
        IPaytable paytable { get; }

        /// <summary>
        /// Constructor.
        /// </summary>
        public PaytableTests()
        {
            paytable = new MockPaytable();

            // Set scenarios
            paytable.AddScenario("4 of a kind", new int[] { 25, 50, 75, 100, 125 }, new CountEvaluator(4));
            paytable.AddScenario("3 of a kind", new int[] { 25, 50, 75, 100, 125 }, new CountEvaluator(3));
        }

        [TestMethod]
        public void TestHierarchies()
        {
            Assert.AreEqual(paytable.CardHierarchy.Count, 13);
            Assert.AreEqual(paytable.CardHierarchy[0], CardFace.Ace);
            Assert.AreEqual(paytable.CardHierarchy[12], CardFace.Two);
        }
    }
}
