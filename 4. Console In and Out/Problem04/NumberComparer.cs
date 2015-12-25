using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4
{
    class NumberComparer
    {
        static void Main(string[] args)
        {
            Console.Write("a = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            double b = double.Parse(Console.ReadLine());

            if (a<b)
            {
                Console.WriteLine($"{b} is greater");
            }
            else
            {
                Console.WriteLine($"{a} is greater");
            }
        }
    }
}
