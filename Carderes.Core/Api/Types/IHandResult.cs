using System;
using System.Collections.Generic;
using System.Text;

namespace Carderes.Core
{
    public interface IHandResult
    {
        bool Matched { get; set; }
        bool Cards { get; set; }
    }
}
