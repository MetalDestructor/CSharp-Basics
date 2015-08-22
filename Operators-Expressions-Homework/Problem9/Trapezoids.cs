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
            Console.Write("Enter height: ");
            double height = Double.Parse(Console.ReadLine());
            Console.Write("Enter base 1: ");
            double base1 = Double.Parse(Console.ReadLine());
            Console.Write("Enter base 2: ");
            double base2 = Double.Parse(Console.ReadLine());

            double area;

            area = ((base1 + base2) / 2) * height;

            Console.WriteLine($"The area is: {area}");
        }
    }
}
