using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Problem02
{
    class BinaryToDecimal
    {
        static void Main(string[] args)
        {
            string num2 = Console.ReadLine();
            int sizeN = num2.Length - 1;
            BigInteger num10 = 0;
            for (int i = 0; i < num2.Length; i++)
            {
                int digit = num2[sizeN] - '0';
                num10 += digit * (BigInteger)Math.Pow(2, i);
                sizeN--;
            }
            Console.WriteLine(num10);
        }
    }
}
