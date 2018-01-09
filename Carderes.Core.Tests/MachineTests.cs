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
            // Create machine
            machine = new Machine();
            machine.SetPaytable(new MockPaytable());

            // Set scenarios
            machine.Paytable.AddScenario("4 of a kind", new int[] { 25, 50, 75, 100, 125 }, new CountEvaluator(4));
            machine.Paytable.AddScenario("3 of a kind", new int[] { 25, 50, 75, 100, 125 }, new CountEvaluator(3));
        }

        [TestMethod]
        public void TestMachine()
        {

        }
    }
}
