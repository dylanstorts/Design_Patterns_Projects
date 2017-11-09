using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public abstract class MultiplyStrategy
    {
        public abstract int MultiplyAlgoritm(int a, int b);
    }
}
