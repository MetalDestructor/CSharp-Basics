using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Problem06
{
    class BinaryToHexaDecimal
    {
        static void Main(string[] args)
        {
            string num2 = Console.ReadLine();
            int sizeN = num2.Length - 1;
            long num10 = 0;
            for (int i = 0; i < num2.Length; i++)
            {
                int digit = num2[sizeN] - '0';
                num10 += digit * (long)Math.Pow(2, i);
                sizeN--;
            }
            string num16 = Convert.ToString(num10, 16);
            Console.WriteLine(num16.ToUpper());
        }
    }
}
