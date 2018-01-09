using System;
using System.Collections.Generic;
using System.Text;

namespace Carderes.Core
{
    public class CountEvaluator : IEvaluator
    {
        int matchCount;

        public CountEvaluator(int matchCount)
        {
            this.matchCount = matchCount;
        }

        public List<IHandResult> Evaluate(List<ICard> hand)
        {
            throw new NotImplementedException();
        }
    }
}
