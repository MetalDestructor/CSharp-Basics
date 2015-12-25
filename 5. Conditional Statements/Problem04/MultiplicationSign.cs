using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem04
{
    class MultiplicationSign
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            double res = a * b * c;

            if (res < 0)
            {
                Console.WriteLine("-");
            }
            else if (res > 0)
            {
                Console.WriteLine("+");
            }
            else
            {
                Console.WriteLine("0");
            }
        }
    }
}
