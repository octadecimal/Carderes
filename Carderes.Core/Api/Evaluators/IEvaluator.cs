using System;
using System.Collections.Generic;
using System.Text;

namespace Carderes.Core
{
    public interface IEvaluator
    {
        IHandResult Evaluate(IHand hand, IPaytable paytable);
    }
}
