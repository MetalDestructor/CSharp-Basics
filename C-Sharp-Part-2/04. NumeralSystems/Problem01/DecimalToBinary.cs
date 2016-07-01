using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Problem01
{
    class DecimalToBinary
    {
        static void Main(string[] args)
        {
            int baseN = 2;
            long num10 = long.Parse(Console.ReadLine());
            string num2 = Convert.ToString(num10, baseN);

            Console.WriteLine(num2);
        }
    }
}
