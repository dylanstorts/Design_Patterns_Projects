using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class MultiplyStratA : MultiplyStrategy
    {
        /*
         *this function will be the simplest of the multiplying strategies
         * i will provide being the system's default multiply
         */
        public override int MultiplyAlgoritm(int a, int b)
        {
            return a * b;
        }
    }
}
