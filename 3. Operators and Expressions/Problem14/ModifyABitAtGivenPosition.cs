using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem14
{
    class ModifyABitAtGivenPosition
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number: ");
            int num = Int32.Parse(Console.ReadLine());
            Console.Write("Enter the position of the digit you want: ");
            int pos = Int32.Parse(Console.ReadLine());
            Console.Write("Enter a bit value: ");
            int v = Int32.Parse(Console.ReadLine());

            if (v == 0)
            {
                int mask = ~(1 << pos);
                int result = num & mask;
                Console.WriteLine(result);
            }
            else
            {
                int mask = 1 << pos;
                int result = num | mask;
                Console.WriteLine(result);
            }
        }
    }
}
