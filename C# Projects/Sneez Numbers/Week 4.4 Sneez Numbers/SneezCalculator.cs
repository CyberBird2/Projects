using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_4._4_Sneez_Numbers
{
    class SneezCalculator
    {
        private int[] catalannumbers ={1, 1, 2, 5, 14, 42, 132, 429, 1430, 4862, 16796, 58786, 208012, 742900, 2674440,
9694845, 35357670, 129644790, 477638700, 1767263190 };

        public SneezCalculator()
        {

        }
        public int  GetSneezNumber(int n)
        {
            return catalannumbers[n] / (catalannumbers[n - 1] - (int)Math.Pow(2, n - 1) - 10);
        }
    }
}
