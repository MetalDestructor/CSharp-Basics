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
            double x = Double.Parse(Console.ReadLine());
            double y = Double.Parse(Console.ReadLine());
            if (Math.Pow((x - 0), 2) + Math.Pow((y - 0), 2) <= Math.Pow(2, 2))
            {
                Console.WriteLine("yes {0:F2}", Math.Sqrt(Math.Pow((x-0),2) + (Math.Pow((y-0),2))));
            }
            else
            {
                Console.WriteLine("no {0:F2}", Math.Sqrt(Math.Pow((x-0),2) + (Math.Pow((y-0),2))));
            }
        }
    }
}
