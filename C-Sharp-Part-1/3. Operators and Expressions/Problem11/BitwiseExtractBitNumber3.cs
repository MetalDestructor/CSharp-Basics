using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem11
{
    class BitwiseExtractBitNumber3
    {
        static void Main(string[] args)
        {
            int pos = 3;
            int num = Int32.Parse(Console.ReadLine());
            int mask = 1 << pos;
            int posAndMask = mask & num;
            int result = posAndMask >> pos;
            Console.WriteLine(result);
        }
    }
}
