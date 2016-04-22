using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem12
{
    class ExtractBitFromInteger
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            int p = Int32.Parse(Console.ReadLine());

            //int mask = 1 << pos;
            //int numAndMask = num & mask;
            //int result = numAndMask >> pos;
			long result = (n >> p) & 1;

            Console.WriteLine(Convert.ToString(result,2));
        }
    }
}
