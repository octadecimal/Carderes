using System;
using System.Collections.Generic;
using System.Text;

namespace Carderes.Core
{
    public class WinScenario : IWinScenario
    {
        public string Description { get; }
        public int[] Payouts { get; }
        public IEvaluator Evaluator { get; }

        public WinScenario(string description, int[] payouts, IEvaluator evaluator)
        {
            Description = description;
            Payouts = payouts;
            Evaluator = evaluator;
        }
    }
}
