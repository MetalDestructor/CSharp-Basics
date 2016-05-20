using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem06
{
    class TriangleSurfaceByTwoSidesAndAnAngle
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double degree = double.Parse(Console.ReadLine());

            double res = (a * b * Math.Sin(degree * Math.PI / 180)) /2;
            Console.WriteLine("{0:F2}", res);
        }
    }
}
