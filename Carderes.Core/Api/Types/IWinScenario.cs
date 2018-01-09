using System;
using System.Collections.Generic;
using System.Text;

namespace Carderes.Core
{
    public interface IWinScenario
    {
        string Description { get; }
        int[] Payouts { get; }
        IEvaluator Evaluator { get; }
    }
}
