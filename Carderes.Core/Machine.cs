using System;
using System.Collections.Generic;
using System.Text;

namespace Carderes.Core
{
    public class Machine : IMachine
    {
        public IPaytable Paytable { get; protected set; }

        public Machine()
        {

        }

        public void SetPaytable(IPaytable paytable)
        {
            Paytable = paytable;
        }
    }
}
