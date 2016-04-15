using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem9
{
    class Trapezoids
    {
        static void Main(string[] args)
        {
            double base1 = Double.Parse(Console.ReadLine());
            double base2 = Double.Parse(Console.ReadLine());
            double height = Double.Parse(Console.ReadLine());

            double area = ((base1 + base2) / 2) * height;

            Console.WriteLine("{0:F7}", area);
        }
    }
}
