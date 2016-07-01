using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Problem10
{
    class NFactorial
    {
        static BigInteger factorial(BigInteger num)
        {
            if (num == 1) return num;
            else if (num == 0) return 1;
            return num*factorial(num-1);
        }
        static void Main(string[] args)
        {
            BigInteger n = BigInteger.Parse(Console.ReadLine());
            Console.WriteLine(factorial(n));
        }
    }
}
