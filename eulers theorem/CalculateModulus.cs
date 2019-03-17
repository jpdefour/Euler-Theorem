using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eulers_theorem
{
    public static class CalculateModulus
    {
        public static ulong Calculate(ulong baseNumber, ulong exponent, ulong modulus)
        {
            ulong remainder = 1;
            while (exponent > 0)
            {
                remainder = (remainder * baseNumber) % modulus;
                exponent--;
            }
            return remainder;
        }
    }
}
