using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem04
{
    class TriangleSurfaceBySideAndAltitude
    {
        static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());
            double altitude = double.Parse(Console.ReadLine());

            Console.WriteLine("{0:F2}", (side * altitude)/2);
        }
    }
}
