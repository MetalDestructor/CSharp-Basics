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
            Console.Write("Enter the number: ");
            int num = Int32.Parse(Console.ReadLine());
            Console.Write("Enter the position of the digit you want: ");
            int pos = Int32.Parse(Console.ReadLine());

            int mask = 1 << pos;
            int numAndMask = num & mask;
            int result = numAndMask >> pos;

            Console.WriteLine(result);
        }
    }
}
