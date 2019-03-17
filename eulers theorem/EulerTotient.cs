using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eulers_theorem
{
    public static class EulerTotient
    {
        public static ulong Calculate(ulong number)
        {
            ulong commonFactorCount = 0;
            for (ulong i = number -1; i > 0; i--)
            {
                if (GCD(number, i) == 1) commonFactorCount++;
            }
            return commonFactorCount;
        }

        private static ulong GCD(ulong a, ulong b)
        {
            while (a != 0 && b != 0)
            {
                if (a > b)
                    a %= b;
                else
                    b %= a;
            }

            return a == 0 ? b : a;
        }
    }
}
