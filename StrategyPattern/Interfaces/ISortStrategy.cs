using Microsoft.VisualStudio.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Interfaces
{
    public interface ISortStrategy
    {
        IOrderedEnumerable<string> Sort(IEnumerable<string> input);
    }
}
