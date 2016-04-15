﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem07
{
    class SortThreeNumbersWithNestedIfs
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            if (a < b)
            {
                if (b < c)
                {
                    Console.WriteLine("{0:0.0}, {1:0.0}, {2:0.0}", c, b, a);
                }
                else
                {
                    Console.WriteLine("{0:0.0}, {1:0.0}, {2:0.0}", b, c, a);
                }
            }
            else if (b < c)
            {
                if (c < a)
                {
                    Console.WriteLine("{0:0.0}, {1:0.0}, {2:0.0}", a, c, b);
                }
                else
                {
                    Console.WriteLine("{0:0.0}, {1:0.0}, {2:0.0}", c, a, b);
                }
            }
            else if (c < a)
            {
                if (a < b)
                {
                    Console.WriteLine("{0:0.0}, {1:0.0}, {2:0.0}", b, a, c);
                }
                else
                {
                    Console.WriteLine("{0:0.0}, {1:0.0}, {2:0.0}", a, b, c);
                }
            }
            else
            {
                Console.WriteLine("{0:0.0}, {1:0.0}, {2:0.0}", a, b, c);
            }
        }
    }
}
