using System;
using System.Collections.Generic;
using Carderes.Core.Tests.Mock;
using Carderes.Core.Tests.Types;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Carderes.Core.Tests
{
    [TestClass]
    public class MachineTests
    {
        IMachine machine;

        /// <summary>
        /// Constructor.
        /// </summary>
        public MachineTests()
        {
            machine = new Machine();
            machine.SetPaytable(new MockPaytable());
        }

        [TestMethod]
        public void TestMachine()
        {

        }
    }
}
