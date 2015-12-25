using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem12
{
    class NullValuesArithmetic
    {
        static void Main(string[] args)
        {
            int? integerValue = null;
            double? doubleValue = null;

            Console.WriteLine("Integer Value : " + integerValue);
            Console.WriteLine("Double Value : " + doubleValue);

            integerValue = 6;
            doubleValue = 6.66;

            for (int i = 0; i < 40; i++)
            {
                Console.Write('-');
            }

            Console.WriteLine("\nInteger Value : " + integerValue);
            Console.WriteLine("Double Value : " + doubleValue);
        }
    }
}
