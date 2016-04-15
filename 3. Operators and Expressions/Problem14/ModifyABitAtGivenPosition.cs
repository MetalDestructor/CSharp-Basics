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
            ulong num = ulong.Parse(Console.ReadLine());
            ulong pos = ulong.Parse(Console.ReadLine());
            ulong v = ulong.Parse(Console.ReadLine());

            if (v == 1)
            {
				ulong mask = v << pos;
                ulong result = (ulong)(num | mask);
                Console.WriteLine(result);
            }
            else
            {
                ulong mask = ~(v << pos);
                ulong result = (ulong)(num & mask);
                Console.WriteLine(result);
            }
        }
    }
}
