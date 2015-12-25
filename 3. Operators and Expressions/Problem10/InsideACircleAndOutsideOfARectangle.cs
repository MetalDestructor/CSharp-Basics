using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem10
{
    class InsideACircleAndOutsideOfARectangle
    {
        static void Main(string[] args)
        {
            Console.Write("x = ");
            double x = Double.Parse(Console.ReadLine());
            Console.Write("y = ");
            double y = Double.Parse(Console.ReadLine());
            if (Math.Pow((x - 1), 2) + Math.Pow((x - 1), 2) <= Math.Pow(1.5, 2) && (x <= 2.5 && x > -0.5) && (y <= 2.5 && y > 1))
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}