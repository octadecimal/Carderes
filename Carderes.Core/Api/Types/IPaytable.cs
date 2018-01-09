using System;
using System.Collections.Generic;
using System.Text;

namespace Carderes.Core
{
    public interface IPaytable
    {
        List<CardFace> CardHierarchy { get; }

        void SetCardHierarchy(List<CardFace> hierarchy);
        void AddScenario(string description, int[] payouts, IEvaluator evaluator);
    }
}
