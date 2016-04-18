using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem6
{
    class QuadraticEquation
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            double D = (Math.Pow(b, 2)) - 4 * a * c;
            if (D == 0)
            {
                double x = -(b) / (2 * a);
                Console.WriteLine("{0:F2}", x);
            }
            else if (D < 0)
            {
                Console.WriteLine("no real roots");
            }
            else
            {
                double x1 = (-(b) - Math.Sqrt(D)) / (2 * a);
                double x2 = (-(b) + Math.Sqrt(D)) / (2 * a);

                Console.WriteLine("{0:F2}\n{2:F2}", x1, x2);
            }
        }
    }
}
