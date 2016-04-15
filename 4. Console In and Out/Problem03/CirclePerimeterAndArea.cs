﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3
{
    class CirclePerimeterAndArea
    {
        static void Main(string[] args)
        {
            const double pi = 3.14159265359;
            Console.Write("r = ");
            double radius = double.Parse(Console.ReadLine());

            double area = pi * Math.Pow(radius, 2);
            double perimeter = 2 * pi * radius;

            Console.WriteLine(String.Format("Area: {0:0.00}", area));
            Console.WriteLine(String.Format("Perimeter: {0:0.00}", perimeter));
        }
    }
}
