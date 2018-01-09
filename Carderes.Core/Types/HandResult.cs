using System;
using System.Collections.Generic;
using System.Text;

namespace Carderes.Core
{
    public class HandResult : IHandResult
    {
        public bool Matched { get; set; }
        public bool Cards { get; set; }
    }
}
