using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem9
{
    class ExchangeVariableValues
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;

            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);

            int swap = a;
            a = b;
            b = swap;

            for (int i = 0; i < 40;i++)
            {
                Console.Write('-');
            }

            Console.WriteLine("\na = " + a);
            Console.WriteLine("b = " + b);
        }
    }
}
