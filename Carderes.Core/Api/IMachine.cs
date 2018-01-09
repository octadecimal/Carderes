using System;
using System.Collections.Generic;
using System.Text;

namespace Carderes.Core
{
    public interface IMachine
    {
        IPaytable Paytable { get; }

        void SetPaytable(IPaytable paytable);
    }
}
