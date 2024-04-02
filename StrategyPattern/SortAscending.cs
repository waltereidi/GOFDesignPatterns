using StrategyPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class SortAscending : ISortStrategy
    {
        public IOrderedEnumerable<string> Sort(IEnumerable<string> input)=>input.OrderBy(x => x);
    }
}
