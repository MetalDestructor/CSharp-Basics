using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem13
{
    class ComparingFloats
    {
        static void Main(string[] args)
        {
            double constant = 0.000001;
            Console.Write("a = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            double b = double.Parse(Console.ReadLine());

            if (Math.Abs(a - b) < constant)
            {
                Console.WriteLine("a = b");
            }
            else
            {
                Console.WriteLine("a != b");
            }
        }
    }
}
