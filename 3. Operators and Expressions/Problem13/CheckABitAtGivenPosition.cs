using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem13
{
    class CheckABitAtGivenPosition
    {
        static void Main(string[] args)
        {
            bool result = true;
            Console.Write("Enter the number: ");
            int num = Int32.Parse(Console.ReadLine());
            Console.Write("Enter the position of the digit you want: ");
            int pos = Int32.Parse(Console.ReadLine());

            int mask = 1 << pos;
            int numAndMask = num & mask;
            int resultNum = numAndMask >> pos;

            if (resultNum == 1)
            {
                result = true;
            }
            else
            {
                result = false;
            }

            Console.WriteLine(result);
        }
    }
}
