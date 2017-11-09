using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class MultiplyStratC : MultiplyStrategy
    {
        /*
         * this method will be the third and most inefficient way to multiply
         * two given integers, we will reverse engineer the second number by
         * incrementing a counter until that counter divided by the first integer
         * results in the next integer
         */
        public override int MultiplyAlgoritm(int a, int b)
        {
            int result = 0;

            while(result / a != b)
                result++;

            return result;
        }
    }
}
