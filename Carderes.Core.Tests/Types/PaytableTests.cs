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
