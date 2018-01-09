using System;
using System.Collections.Generic;
using System.Text;

namespace Carderes.Core
{
    public interface IEvaluator
    {
        List<IHandResult> Evaluate(List<ICard> hand);
    }
}
