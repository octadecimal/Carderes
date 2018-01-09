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

        public IHandResult Evaluate(IHand hand, IPaytable paytable)
        {
            IHandResult result = new HandResult();

            // Loop through each card face in hierarchy
            for (int i = 0; i < paytable.CardHierarchy.Count; i++)
            {
                // Check count
                if(hand.ContainsAtLeast(paytable.CardHierarchy[i], matchCount))
                {
                    result.Matched = true;
                }
            }

            return result;
        }
    }
}
