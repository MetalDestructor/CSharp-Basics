using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem14
{
    class DecimalToBinary
    {
        static void Main(string[] args)
        {
            long num = long.Parse(Console.ReadLine());
            string binaryNum = "";
            while (num != 0)
            {
                binaryNum += (num % 2);
                num = num / 2;
            }
            char[] rev = binaryNum.ToCharArray();
            Array.Reverse(rev);
            string realBN = new string(rev);
            Console.WriteLine(realBN);
        }
    }
}
