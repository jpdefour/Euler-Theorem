using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eulers_theorem
{
    class Program
    {
        const ulong Base = 1532762;
        const ulong Exponent = 3169667;
        const ulong ModulusFactor = 8014003;
        static void Main(string[] args)
        {
            var phi = EulerTotient.Calculate(ModulusFactor);
            var lowestExponent = Exponent % ModulusFactor;
            var modulusCalculated = CalculateModulus.Calculate(Base, lowestExponent, ModulusFactor);

            Console.WriteLine("Euler's Tolient = " + phi);
            Console.WriteLine("Last digits = " + modulusCalculated);

            Console.ReadLine();
        }
    }
}
