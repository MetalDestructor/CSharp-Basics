using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem05
{
    class TheBiggestOfThreeNumbers
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double max = a;
            if (max < b)
            {
                max = b;
                if (max < c)
                {
                    max = c;
                }
            }
            else if (max < c)
            {
                max = c;
            }
            Console.WriteLine(max);
        }
    }
}
