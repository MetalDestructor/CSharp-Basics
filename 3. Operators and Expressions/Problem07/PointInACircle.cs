using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem7
{
    class PointInACircle
    {
        static void Main(string[] args)
        {
            Console.Write("x = ");
            double x = Double.Parse(Console.ReadLine());
            Console.Write("y = ");
            double y = Double.Parse(Console.ReadLine());
            if (Math.Pow((x - 0), 2) + Math.Pow((y - 0), y) <= Math.Pow(2, 2))
            {
                Console.WriteLine($"The point with x = {x} and y = {y} is in the circle");
            }
            else
            {
                Console.WriteLine($"The point with x = {x} and y = {y} is not in the circle");
            }
        }
    }
}
