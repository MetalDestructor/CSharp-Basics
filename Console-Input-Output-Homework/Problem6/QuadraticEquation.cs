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
            Console.Write("a = ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b = ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("c = ");
            double c = Convert.ToDouble(Console.ReadLine());

            double D = (Math.Pow(b, 2)) - 4 * a * c;
            if (D == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine($"x = {x}");
            }
            else if (D < 0)
            {
                Console.WriteLine("No real roots");
            }
            else
            {
                double x1 = (-b - Math.Sqrt(D)) / (2 * a);
                double x2 = (-b + Math.Sqrt(D)) / (2 * a);

                Console.WriteLine($"x1 = {x1}\nx2 = {x2}");
            }
        }
    }
}
