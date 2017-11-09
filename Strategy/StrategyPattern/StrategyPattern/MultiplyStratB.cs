using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class MultiplyStratB : MultiplyStrategy
    {
        /*
         * this will be the second and slightly more complex method of multiplying
         * two numbers being a recursive multiple method with onlu addition and
         * subtraction used
         */
        public override int MultiplyAlgoritm(int a, int b)
        {
            if(b == 0)
                return 0;

                return a + MultiplyAlgoritm(a, b - 1);
        }
    }
}
