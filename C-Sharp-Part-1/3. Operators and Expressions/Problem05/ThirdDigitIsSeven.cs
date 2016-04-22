using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem5
{
    class ThirdDigitIsSeven
    {
        static void Main(string[] args)
        {
            int unconvertedNumber = int.Parse(Console.ReadLine());
            int stillUnconverted = unconvertedNumber / 100;
            int number = stillUnconverted % 10;

            if (number == 7)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false {0}", number);
            }
        }
    }
}
