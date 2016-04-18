using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem06
{
    class TheBiggestOfFiveNumbers
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double d = double.Parse(Console.ReadLine());
            double e = double.Parse(Console.ReadLine());

            double max = a;

            if (max < b)
            {
                max = b;
                if (max < c)
                {
                    max = c;
                    if (max < d)
                    {
                        max = d;
                        if (max < e)
                        {
                            max = e;
                        }
                    }
                }
            }
            else if (max < c)
            {
                max = c;
                if (max < d)
                {
                    max = d;
                    if (max < e)
                    {
                        max = e;
                    }
                }
            }
            else if (max < d)
            {
                max = d;
                if (max < e)
                {
                    max = e;
                }
            }
            else if (max < e)
            {
                max = e;
            }

            Console.WriteLine(max);
        }
    }
}
