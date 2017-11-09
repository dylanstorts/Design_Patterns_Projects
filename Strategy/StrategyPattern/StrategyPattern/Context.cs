using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class Context
    {
        //the folllowing are the two numbers the user entered to be multiplied
        int A;
        int B;

        MultiplyStrategy multiplyStrat;

        public Context(MultiplyStrategy multStrat)
        {
            this.multiplyStrat = multStrat;
        }

        public int ContextMultiplier(int a, int b)
        {
            return multiplyStrat.MultiplyAlgoritm(a, b);
        }
    }
}
